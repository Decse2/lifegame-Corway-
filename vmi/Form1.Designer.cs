namespace vmi
{
    partial class Conway_Life_Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbGrid = new PictureBox();
            numSSize = new NumericUpDown();
            label1 = new Label();
            Btn_Reset = new Button();
            button2 = new Button();
            Btn_Advance = new Button();
            Btn_Go = new Button();
            button4 = new Button();
            cboCells = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSSize).BeginInit();
            SuspendLayout();
            // 
            // pbGrid
            // 
            pbGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbGrid.Location = new Point(12, 65);
            pbGrid.Name = "pbGrid";
            pbGrid.Size = new Size(920, 400);
            pbGrid.TabIndex = 0;
            pbGrid.TabStop = false;
            pbGrid.Click += pbGrid_Click;
            // 
            // numSSize
            // 
            numSSize.Location = new Point(12, 27);
            numSSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numSSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numSSize.Name = "numSSize";
            numSSize.Size = new Size(49, 23);
            numSSize.TabIndex = 1;
            numSSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Cell size";
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(67, 27);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(75, 23);
            Btn_Reset.TabIndex = 3;
            Btn_Reset.Text = "Reset";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Btn_Advance
            // 
            Btn_Advance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Advance.Location = new Point(695, 25);
            Btn_Advance.Name = "Btn_Advance";
            Btn_Advance.Size = new Size(75, 23);
            Btn_Advance.TabIndex = 5;
            Btn_Advance.Text = "Advance";
            Btn_Advance.UseVisualStyleBackColor = true;
            // 
            // Btn_Go
            // 
            Btn_Go.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Go.Location = new Point(776, 25);
            Btn_Go.Name = "Btn_Go";
            Btn_Go.Size = new Size(75, 23);
            Btn_Go.TabIndex = 6;
            Btn_Go.Text = "Go";
            Btn_Go.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(857, 25);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // cboCells
            // 
            cboCells.FormattingEnabled = true;
            cboCells.Location = new Point(546, 25);
            cboCells.Name = "cboCells";
            cboCells.Size = new Size(143, 23);
            cboCells.TabIndex = 8;
            // 
            // Conway_Life_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 581);
            Controls.Add(cboCells);
            Controls.Add(button4);
            Controls.Add(Btn_Go);
            Controls.Add(Btn_Advance);
            Controls.Add(button2);
            Controls.Add(Btn_Reset);
            Controls.Add(label1);
            Controls.Add(numSSize);
            Controls.Add(pbGrid);
            MinimumSize = new Size(960, 620);
            Name = "Conway_Life_Game";
            Text = "Conway's Life Game";
            Load += Conway_Life_Game_Load;
            ((System.ComponentModel.ISupportInitialize)pbGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGrid;
        private NumericUpDown numSSize;
        private Label label1;
        private Button Btn_Reset;
        private Button button2;
        private Button Btn_Advance;
        private Button Btn_Go;
        private Button button4;
        private ComboBox cboCells;
    }
}