namespace ExtendedGraphics
{
    partial class FormFive
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.овалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.даToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elipseToolStripMenuItem,
            this.овалToolStripMenuItem,
            this.квадратToolStripMenuItem,
            this.треугольникToolStripMenuItem,
            this.даToolStripMenuItem,
            this.гномToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // овалToolStripMenuItem
            // 
            this.овалToolStripMenuItem.Name = "овалToolStripMenuItem";
            this.овалToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.овалToolStripMenuItem.Text = "Another elipse";
            this.овалToolStripMenuItem.Click += new System.EventHandler(this.овалToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.квадратToolStripMenuItem.Text = "Rectangle";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.треугольникToolStripMenuItem.Text = "Triangle";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.треугольникToolStripMenuItem_Click);
            // 
            // даToolStripMenuItem
            // 
            this.даToolStripMenuItem.Name = "даToolStripMenuItem";
            this.даToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.даToolStripMenuItem.Text = "Yes";
            this.даToolStripMenuItem.Click += new System.EventHandler(this.даToolStripMenuItem_Click);
            // 
            // гномToolStripMenuItem
            // 
            this.гномToolStripMenuItem.Name = "гномToolStripMenuItem";
            this.гномToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гномToolStripMenuItem.Text = "Gnome";
            this.гномToolStripMenuItem.Click += new System.EventHandler(this.гномToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*jpg";
            // 
            // FormFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFive";
            this.Text = "FormFive";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem овалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem даToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гномToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}