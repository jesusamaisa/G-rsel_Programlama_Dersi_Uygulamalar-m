namespace ReadOnlySifre
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
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Btn_tamam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_adiniz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_soyadiniz = new System.Windows.Forms.TextBox();
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
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(100, 15);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.PasswordChar = '*';
            this.Txt_sifre.Size = new System.Drawing.Size(200, 23);
            this.Txt_sifre.TabIndex = 1;
            // 
            // Btn_tamam
            // 
            this.Btn_tamam.Location = new System.Drawing.Point(100, 45);
            this.Btn_tamam.Name = "Btn_tamam";
            this.Btn_tamam.Size = new System.Drawing.Size(200, 30);
            this.Btn_tamam.TabIndex = 2;
            this.Btn_tamam.Text = "Tamam";
            this.Btn_tamam.UseVisualStyleBackColor = true;
            this.Btn_tamam.Click += new System.EventHandler(this.Btn_tamam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Adınız";
            // 
            // Txt_adiniz
            // 
            this.Txt_adiniz.Location = new System.Drawing.Point(100, 89);
            this.Txt_adiniz.Name = "Txt_adiniz";
            this.Txt_adiniz.Size = new System.Drawing.Size(200, 23);
            this.Txt_adiniz.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadınız";
            // 
            // Txt_soyadiniz
            // 
            this.Txt_soyadiniz.Location = new System.Drawing.Point(100, 120);
            this.Txt_soyadiniz.Name = "Txt_soyadiniz";
            this.Txt_soyadiniz.Size = new System.Drawing.Size(200, 23);
            this.Txt_soyadiniz.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.Txt_soyadiniz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_adiniz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_tamam);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Muhammed İsa Erkan 221001019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.Button Btn_tamam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_adiniz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_soyadiniz;
    }
}
