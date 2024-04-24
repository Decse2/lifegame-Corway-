using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json.Serialization;

namespace vmi
{
    public partial class Conway_Life_Game : Form
    {
        public Conway_Life_Game()
        {
            InitializeComponent();
        }
        private void Conway_Life_Game_Load(object sender, EventArgs e)
        {
            CreateGridSurface();
            GetActiveCounts();
        }

        private void CreateGridSurface()
        {
            Point locPoint;
            Cell newCell;
            Random random = new Random();
            int rows = (int)(pbGrid.Height / numSSize.Value);
            int cols = (int)(pbGrid.Width / numSSize.Value);


            using (Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.Aquamarine))
            {
                g.Clear(Color.Black);
                pbGrid.Image = (Bitmap)bmp.Clone();

                Cell.gridCells.Clear();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        locPoint = new Point((int)(j * numSSize.Value), (int)(i * numSSize.Value));
                        newCell = new Cell(locPoint, j, i);
                        newCell.IsAlive = (random.Next(100) < 15) ? true : false;
                        Cell.gridCells.Add(newCell);
                    }
                }

                // Plot all the newly created cells to the grid.
                foreach (Cell cell in Cell.gridCells)
                {
                    if (cell.IsAlive)
                    {
                        g.FillRectangle(cellBrush, new Rectangle(cell.Location,
                            new Size((int)numSSize.Value - 1, (int)numSSize.Value - 1)));
                    }
                }

                pbGrid.Image = (Bitmap)bmp.Clone();
            }
        }

        private void pbGrid_Click(object sender, EventArgs e)
        {

        }

        private void GetActiveCounts()
        {
            cboCells.Items.Clear();

            foreach (Cell cell in Cell.gridCells)
            {
                cboCells.Items.Add($"X: {cell.XPos}, Y: {cell.YPos}, Count: {cell.LiveAdjacent()}");
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            CreateGridSurface();
            GetActiveCounts();
        }

        private void Color_Change_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if(colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackbround = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
            }
        }
    }

    public class Cell
    {
        public static List<Cell> gridCells = new List<Cell>();

        private Point cLocation;
        private int cXPos;
        private int cYPos;
        private Boolean cIsAlive;

        public Cell(Point location, int x, int y)
        {
            this.Location = location;
            this.YPos = y;
            this.XPos = x;
        }

        public Point Location
        {
            get { return cLocation; }
            set { cLocation = value; }
        }

        public int XPos
        {
            get { return cXPos; }
            set { cXPos = value; }
        }

        public int YPos
        {
            get { return cYPos; }
            set { cYPos = value; }
        }

        public Boolean IsAlive
        {
            get { return cIsAlive; }
            set { cIsAlive = value; }
        }
        public int LiveAdjacent()
        {
            int liveAjacent = 0;
            foreach (Cell cell in Cell.gridCells)
            {

                if (cell.cLocation != this.cLocation && cell.IsAlive)
                {
                    if (Math.Abs(cell.XPos - this.XPos) < 2 && Math.Abs(cell.XPos - this.XPos) < 2)
                    {
                        liveAjacent++;
                    }
                }

            }

            return liveAjacent;
        }

    }
}