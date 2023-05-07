namespace Ornek2
{
    partial class Main
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
            this.matematikselİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asalSayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonksiyonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karekökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matematikselİşlemlerToolStripMenuItem,
            this.fonksiyonlarToolStripMenuItem,
            this.stringİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matematikselİşlemlerToolStripMenuItem
            // 
            this.matematikselİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asalSayıToolStripMenuItem,
            this.karekökToolStripMenuItem});
            this.matematikselİşlemlerToolStripMenuItem.Name = "matematikselİşlemlerToolStripMenuItem";
            this.matematikselİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.matematikselİşlemlerToolStripMenuItem.Text = "Matematiksel İşlemler";
            // 
            // asalSayıToolStripMenuItem
            // 
            this.asalSayıToolStripMenuItem.Name = "asalSayıToolStripMenuItem";
            this.asalSayıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asalSayıToolStripMenuItem.Text = "Asal Sayı";
            this.asalSayıToolStripMenuItem.Click += new System.EventHandler(this.asalSayıToolStripMenuItem_Click);
            // 
            // fonksiyonlarToolStripMenuItem
            // 
            this.fonksiyonlarToolStripMenuItem.Name = "fonksiyonlarToolStripMenuItem";
            this.fonksiyonlarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.fonksiyonlarToolStripMenuItem.Text = "Fonksiyonlar";
            // 
            // stringİşlemlerToolStripMenuItem
            // 
            this.stringİşlemlerToolStripMenuItem.Name = "stringİşlemlerToolStripMenuItem";
            this.stringİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.stringİşlemlerToolStripMenuItem.Text = "String İşlemler";
            // 
            // karekökToolStripMenuItem
            // 
            this.karekökToolStripMenuItem.Name = "karekökToolStripMenuItem";
            this.karekökToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.karekökToolStripMenuItem.Text = "Karekök";
            this.karekökToolStripMenuItem.Click += new System.EventHandler(this.karekökToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 398);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matematikselİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asalSayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonksiyonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karekökToolStripMenuItem;
    }
}



