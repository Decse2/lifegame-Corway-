using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dfwa
{
    public partial class Elet_jatek : Form
    {
        public Elet_jatek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private PointF currentPosition;
        private void felulet_mousemove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            Mouse.Text = string.Format("{0},{1}",e.Location.X,e.Location.Y);
            label2.Text = string.Format("{0},{1}", currentPosition.X, currentPosition.Y);
        }
        //Screen DPI
        private float DPI
        {
            get
            {
                using(var g=CreateGraphics())
                {
                    return g.DpiX;
                }
            }
        }
        // Convert system points to wordl point
        private PointF PointToCartesian(Point point)
        {
            return new PointF(point.X, point.Y);
        }

    }
}
