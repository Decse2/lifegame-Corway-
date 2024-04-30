namespace GameOfLife
{
    partial class ConwayMain
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
            btnReset = new Button();
            btnAdvance = new Button();
            btnGo = new Button();
            btnClear = new Button();
            mMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadPatternToolStripMenuItem = new ToolStripMenuItem();
            savePatternToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            gameToolStripMenuItem = new ToolStripMenuItem();
            resetGridToolStripMenuItem = new ToolStripMenuItem();
            clearGridToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            advanceToolStripMenuItem = new ToolStripMenuItem();
            goToolStripMenuItem = new ToolStripMenuItem();
            nudDelay = new NumericUpDown();
            label2 = new Label();
            fdSave = new SaveFileDialog();
            clr_change = new Button();
            ((System.ComponentModel.ISupportInitialize)pbGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSSize).BeginInit();
            mMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelay).BeginInit();
            SuspendLayout();
            // 
            // pbGrid
            // 
            pbGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbGrid.Location = new Point(19, 42);
            pbGrid.Name = "pbGrid";
            pbGrid.Size = new Size(913, 450);
            pbGrid.TabIndex = 0;
            pbGrid.TabStop = false;
            pbGrid.MouseClick += pbGrid_MouseClick;
            // 
            // numSSize
            // 
            numSSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numSSize.Location = new Point(88, 506);
            numSSize.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numSSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numSSize.Name = "numSSize";
            numSSize.Size = new Size(60, 23);
            numSSize.TabIndex = 1;
            numSSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(19, 508);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Cell Size:";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(168, 504);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdvance
            // 
            btnAdvance.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdvance.Location = new Point(752, 504);
            btnAdvance.Name = "btnAdvance";
            btnAdvance.Size = new Size(75, 23);
            btnAdvance.TabIndex = 4;
            btnAdvance.Text = "Advance";
            btnAdvance.UseVisualStyleBackColor = true;
            btnAdvance.Click += btnAdvance_Click;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGo.Location = new Point(833, 504);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 5;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(258, 504);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // mMain
            // 
            mMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, gameToolStripMenuItem });
            mMain.Location = new Point(0, 0);
            mMain.Name = "mMain";
            mMain.Size = new Size(944, 24);
            mMain.TabIndex = 7;
            mMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadPatternToolStripMenuItem, savePatternToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // loadPatternToolStripMenuItem
            // 
            loadPatternToolStripMenuItem.Name = "loadPatternToolStripMenuItem";
            loadPatternToolStripMenuItem.Size = new Size(141, 22);
            loadPatternToolStripMenuItem.Text = "&Load Pattern";
            loadPatternToolStripMenuItem.Click += loadPatternToolStripMenuItem_Click;
            // 
            // savePatternToolStripMenuItem
            // 
            savePatternToolStripMenuItem.Name = "savePatternToolStripMenuItem";
            savePatternToolStripMenuItem.Size = new Size(141, 22);
            savePatternToolStripMenuItem.Text = "&Save Pattern";
            savePatternToolStripMenuItem.Click += savePatternToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetGridToolStripMenuItem, clearGridToolStripMenuItem, toolStripSeparator1, advanceToolStripMenuItem, goToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(50, 20);
            gameToolStripMenuItem.Text = "&Game";
            // 
            // resetGridToolStripMenuItem
            // 
            resetGridToolStripMenuItem.Name = "resetGridToolStripMenuItem";
            resetGridToolStripMenuItem.Size = new Size(127, 22);
            resetGridToolStripMenuItem.Text = "&Reset Grid";
            resetGridToolStripMenuItem.Click += resetGridToolStripMenuItem_Click;
            // 
            // clearGridToolStripMenuItem
            // 
            clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            clearGridToolStripMenuItem.Size = new Size(127, 22);
            clearGridToolStripMenuItem.Text = "&Clear Grid";
            clearGridToolStripMenuItem.Click += clearGridToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(124, 6);
            // 
            // advanceToolStripMenuItem
            // 
            advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            advanceToolStripMenuItem.Size = new Size(127, 22);
            advanceToolStripMenuItem.Text = "&Advance";
            advanceToolStripMenuItem.Click += advanceToolStripMenuItem_Click;
            // 
            // goToolStripMenuItem
            // 
            goToolStripMenuItem.Name = "goToolStripMenuItem";
            goToolStripMenuItem.Size = new Size(127, 22);
            goToolStripMenuItem.Text = "&Go";
            goToolStripMenuItem.Click += goToolStripMenuItem_Click;
            // 
            // nudDelay
            // 
            nudDelay.Location = new Point(424, 506);
            nudDelay.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudDelay.Name = "nudDelay";
            nudDelay.Size = new Size(63, 23);
            nudDelay.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 508);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Delay (ms):";
            // 
            // clr_change
            // 
            clr_change.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clr_change.Location = new Point(493, 506);
            clr_change.Name = "clr_change";
            clr_change.Size = new Size(75, 23);
            clr_change.TabIndex = 10;
            clr_change.Text = "Color";
            clr_change.UseVisualStyleBackColor = true;
            clr_change.Click += clr_change_Click;
            // 
            // ConwayMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 581);
            Controls.Add(clr_change);
            Controls.Add(label2);
            Controls.Add(nudDelay);
            Controls.Add(btnClear);
            Controls.Add(btnGo);
            Controls.Add(btnAdvance);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(numSSize);
            Controls.Add(pbGrid);
            Controls.Add(mMain);
            MainMenuStrip = mMain;
            MinimumSize = new Size(960, 620);
            Name = "ConwayMain";
            Text = "Conway's Game of Life";
            FormClosing += ConwayMain_FormClosing;
            Load += ConwayMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSSize).EndInit();
            mMain.ResumeLayout(false);
            mMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGrid;
        private NumericUpDown numSSize;
        private Label label1;
        private Button btnReset;
        private Button btnAdvance;
        private Button btnGo;
        private Button btnClear;
        private MenuStrip mMain;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem resetGridToolStripMenuItem;
        private ToolStripMenuItem clearGridToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem advanceToolStripMenuItem;
        private ToolStripMenuItem goToolStripMenuItem;
        private NumericUpDown nudDelay;
        private Label label2;
        private SaveFileDialog fdSave;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadPatternToolStripMenuItem;
        private ToolStripMenuItem savePatternToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button clr_change;
    }
}
