namespace SifreGirisi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_tamam = new System.Windows.Forms.Button();
            this.Btn_iptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_tamam
            // 
            this.Btn_tamam.Location = new System.Drawing.Point(70, 50);
            this.Btn_tamam.Name = "Btn_tamam";
            this.Btn_tamam.Size = new System.Drawing.Size(95, 32);
            this.Btn_tamam.TabIndex = 2;
            this.Btn_tamam.Text = "Tamam";
            this.Btn_tamam.UseVisualStyleBackColor = true;
            this.Btn_tamam.Click += new System.EventHandler(this.Btn_tamam_Click);
            // 
            // Btn_iptal
            // 
            this.Btn_iptal.Location = new System.Drawing.Point(175, 50);
            this.Btn_iptal.Name = "Btn_iptal";
            this.Btn_iptal.Size = new System.Drawing.Size(95, 32);
            this.Btn_iptal.TabIndex = 3;
            this.Btn_iptal.Text = "İptal";
            this.Btn_iptal.UseVisualStyleBackColor = true;
            this.Btn_iptal.Click += new System.EventHandler(this.Btn_iptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.TabIndex = 4;
            this.label2.Text = "(Şifre: 1234)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientSize = new System.Drawing.Size(300, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_iptal);
            this.Controls.Add(this.Btn_tamam);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Muhammed İsa Erkan 221001019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_tamam;
        private System.Windows.Forms.Button Btn_iptal;
        private System.Windows.Forms.Label label2;
    }
}
