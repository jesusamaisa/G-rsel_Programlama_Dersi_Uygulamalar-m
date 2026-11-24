namespace SeciliBolge
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
            this.Txt_anametin = new System.Windows.Forms.TextBox();
            this.Btn_tumunu_sec = new System.Windows.Forms.Button();
            this.Btn_buyuk_harf = new System.Windows.Forms.Button();
            this.Btn_kucuk_harf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_aranan = new System.Windows.Forms.TextBox();
            this.Btn_bul = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_anametin
            // 
            this.Txt_anametin.Location = new System.Drawing.Point(12, 12);
            this.Txt_anametin.Name = "Txt_anametin";
            this.Txt_anametin.Multiline = true;
            this.Txt_anametin.Size = new System.Drawing.Size(330, 295);
            this.Txt_anametin.TabIndex = 0;
            this.Txt_anametin.Text = "Visual C# ile nesneye yönelik programlama.\r\nSeçili bölge ile çalışma örneği.\r\nAranan kelimeyi bulup seçebilirsiniz.";
            // 
            // Btn_tumunu_sec
            // 
            this.Btn_tumunu_sec.Location = new System.Drawing.Point(352, 12);
            this.Btn_tumunu_sec.Name = "Btn_tumunu_sec";
            this.Btn_tumunu_sec.Size = new System.Drawing.Size(155, 32);
            this.Btn_tumunu_sec.TabIndex = 1;
            this.Btn_tumunu_sec.Text = "Tümünü Seç";
            this.Btn_tumunu_sec.UseVisualStyleBackColor = true;
            this.Btn_tumunu_sec.Click += new System.EventHandler(this.Btn_tumunu_sec_Click);
            // 
            // Btn_buyuk_harf
            // 
            this.Btn_buyuk_harf.Location = new System.Drawing.Point(352, 50);
            this.Btn_buyuk_harf.Name = "Btn_buyuk_harf";
            this.Btn_buyuk_harf.Size = new System.Drawing.Size(155, 32);
            this.Btn_buyuk_harf.TabIndex = 2;
            this.Btn_buyuk_harf.Text = "Büyük harfe çevir";
            this.Btn_buyuk_harf.UseVisualStyleBackColor = true;
            this.Btn_buyuk_harf.Click += new System.EventHandler(this.Btn_buyuk_harf_Click);
            // 
            // Btn_kucuk_harf
            // 
            this.Btn_kucuk_harf.Location = new System.Drawing.Point(352, 88);
            this.Btn_kucuk_harf.Name = "Btn_kucuk_harf";
            this.Btn_kucuk_harf.Size = new System.Drawing.Size(155, 32);
            this.Btn_kucuk_harf.TabIndex = 3;
            this.Btn_kucuk_harf.Text = "Küçük harfe çevir";
            this.Btn_kucuk_harf.UseVisualStyleBackColor = true;
            this.Btn_kucuk_harf.Click += new System.EventHandler(this.Btn_kucuk_harf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 135);
            this.label1.Name = "label1";
            this.label1.TabIndex = 4;
            this.label1.Text = "Aranan kelime";
            // 
            // Txt_aranan
            // 
            this.Txt_aranan.Location = new System.Drawing.Point(352, 155);
            this.Txt_aranan.Name = "Txt_aranan";
            this.Txt_aranan.Size = new System.Drawing.Size(155, 23);
            this.Txt_aranan.TabIndex = 5;
            this.Txt_aranan.Text = "ana";
            // 
            // Btn_bul
            // 
            this.Btn_bul.Location = new System.Drawing.Point(352, 184);
            this.Btn_bul.Name = "Btn_bul";
            this.Btn_bul.Size = new System.Drawing.Size(155, 32);
            this.Btn_bul.TabIndex = 6;
            this.Btn_bul.Text = "Bul";
            this.Btn_bul.UseVisualStyleBackColor = true;
            this.Btn_bul.Click += new System.EventHandler(this.Btn_bul_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.Location = new System.Drawing.Point(352, 222);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(155, 32);
            this.Btn_sil.TabIndex = 7;
            this.Btn_sil.Text = "Sil";
            this.Btn_sil.UseVisualStyleBackColor = true;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.Btn_bul);
            this.Controls.Add(this.Txt_aranan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_kucuk_harf);
            this.Controls.Add(this.Btn_buyuk_harf);
            this.Controls.Add(this.Btn_tumunu_sec);
            this.Controls.Add(this.Txt_anametin);
            this.Name = "Form1";
            this.Text = "Muhammed İsa Erkan 221001019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_anametin;
        private System.Windows.Forms.Button Btn_tumunu_sec;
        private System.Windows.Forms.Button Btn_buyuk_harf;
        private System.Windows.Forms.Button Btn_kucuk_harf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_aranan;
        private System.Windows.Forms.Button Btn_bul;
        private System.Windows.Forms.Button Btn_sil;
    }
}
