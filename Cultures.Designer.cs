namespace Cultures
{
    partial class Cultures
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hungaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cultureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cultureToolStripMenuItem
            // 
            this.cultureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSAToolStripMenuItem,
            this.hungaryToolStripMenuItem,
            this.russiaToolStripMenuItem});
            this.cultureToolStripMenuItem.Name = "cultureToolStripMenuItem";
            this.cultureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cultureToolStripMenuItem.Text = "&Culture";
            // 
            // uSAToolStripMenuItem
            // 
            this.uSAToolStripMenuItem.Name = "uSAToolStripMenuItem";
            this.uSAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uSAToolStripMenuItem.Text = "&USA";
            this.uSAToolStripMenuItem.Click += new System.EventHandler(this.uSAToolStripMenuItem_Click);
            // 
            // hungaryToolStripMenuItem
            // 
            this.hungaryToolStripMenuItem.Name = "hungaryToolStripMenuItem";
            this.hungaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hungaryToolStripMenuItem.Text = "&Hungary";
            this.hungaryToolStripMenuItem.Click += new System.EventHandler(this.hungaryToolStripMenuItem_Click);
            // 
            // russiaToolStripMenuItem
            // 
            this.russiaToolStripMenuItem.Name = "russiaToolStripMenuItem";
            this.russiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.russiaToolStripMenuItem.Text = "&Russia";
            this.russiaToolStripMenuItem.Click += new System.EventHandler(this.russiaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(143, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 294);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Cultures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cultures";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cultures_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hungaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

