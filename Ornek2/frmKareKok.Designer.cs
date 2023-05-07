namespace Ornek2
{
    partial class frmKareKok
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnkareKok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(211, 53);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(286, 23);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            // 
            // btnkareKok
            // 
            this.btnkareKok.Location = new System.Drawing.Point(409, 82);
            this.btnkareKok.Name = "btnkareKok";
            this.btnkareKok.Size = new System.Drawing.Size(88, 47);
            this.btnkareKok.TabIndex = 2;
            this.btnkareKok.Text = "KareKök";
            this.btnkareKok.UseVisualStyleBackColor = true;
            this.btnkareKok.Click += new System.EventHandler(this.btnkareKok_Click);
            // 
            // frmKareKok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 361);
            this.Controls.Add(this.btnkareKok);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKareKok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKareKok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnkareKok;
    }
}