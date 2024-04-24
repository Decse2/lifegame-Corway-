namespace dfwa
{
    partial class Elet_jatek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.felulet = new System.Windows.Forms.PictureBox();
            this.Mouse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.felulet)).BeginInit();
            this.SuspendLayout();
            // 
            // felulet
            // 
            this.felulet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.felulet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.felulet.Location = new System.Drawing.Point(16, 35);
            this.felulet.Name = "felulet";
            this.felulet.Size = new System.Drawing.Size(1920, 1080);
            this.felulet.TabIndex = 0;
            this.felulet.TabStop = false;
            this.felulet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.felulet_mousemove);
            // 
            // Mouse
            // 
            this.Mouse.AutoSize = true;
            this.Mouse.Location = new System.Drawing.Point(12, 9);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(161, 23);
            this.Mouse.TabIndex = 1;
            this.Mouse.Text = "Mouse Location";
            this.Mouse.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label2";
            // 
            // Elet_jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mouse);
            this.Controls.Add(this.felulet);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Elet_jatek";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.felulet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox felulet;
        private System.Windows.Forms.Label Mouse;
        private System.Windows.Forms.Label label2;
    }
}

