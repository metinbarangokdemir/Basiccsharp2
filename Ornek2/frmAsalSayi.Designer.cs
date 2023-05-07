namespace Ornek2
{
    partial class frmAsalSayi
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnkontrolEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(196, 93);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(365, 23);
            this.txtSayi1.TabIndex = 1;
            // 
            // btnkontrolEt
            // 
            this.btnkontrolEt.Location = new System.Drawing.Point(461, 133);
            this.btnkontrolEt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkontrolEt.Name = "btnkontrolEt";
            this.btnkontrolEt.Size = new System.Drawing.Size(100, 28);
            this.btnkontrolEt.TabIndex = 2;
            this.btnkontrolEt.Text = "Kontrol Et";
            this.btnkontrolEt.UseVisualStyleBackColor = true;
            this.btnkontrolEt.Click += new System.EventHandler(this.btnkontrolEt_Click);
            // 
            // frmAsalSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 302);
            this.Controls.Add(this.btnkontrolEt);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAsalSayi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsalSayi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnkontrolEt;
    }
}