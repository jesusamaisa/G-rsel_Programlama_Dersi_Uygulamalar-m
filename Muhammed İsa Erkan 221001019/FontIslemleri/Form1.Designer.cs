namespace FontIslemleri
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Txt_yazi = new System.Windows.Forms.TextBox();
            this.Btn_kalin = new System.Windows.Forms.Button();
            this.Btn_egik = new System.Windows.Forms.Button();
            this.Btn_altcizili = new System.Windows.Forms.Button();
            this.Btn_ustucizili = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_boyut = new System.Windows.Forms.NumericUpDown();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_boyut)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_yazi
            // 
            this.Txt_yazi.Location = new System.Drawing.Point(12, 12);
            this.Txt_yazi.Name = "Txt_yazi";
            this.Txt_yazi.Multiline = true;
            this.Txt_yazi.Font = new Font("Microsoft Sans Serif", 14F);
            this.Txt_yazi.Size = new System.Drawing.Size(390, 50);
            this.Txt_yazi.TabIndex = 0;
            this.Txt_yazi.Text = "Muhammed İsa Erkan";
            // 
            // Btn_kalin
            // 
            this.Btn_kalin.Location = new System.Drawing.Point(12, 72);
            this.Btn_kalin.Name = "Btn_kalin";
            this.Btn_kalin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Btn_kalin.Size = new System.Drawing.Size(90, 32);
            this.Btn_kalin.TabIndex = 1;
            this.Btn_kalin.Text = "Kalın";
            this.Btn_kalin.UseVisualStyleBackColor = true;
            this.Btn_kalin.Click += new System.EventHandler(this.Btn_kalin_Click);
            // 
            // Btn_egik
            // 
            this.Btn_egik.Location = new System.Drawing.Point(108, 72);
            this.Btn_egik.Name = "Btn_egik";
            this.Btn_egik.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.Btn_egik.Size = new System.Drawing.Size(90, 32);
            this.Btn_egik.TabIndex = 2;
            this.Btn_egik.Text = "Eğik";
            this.Btn_egik.UseVisualStyleBackColor = true;
            this.Btn_egik.Click += new System.EventHandler(this.Btn_egik_Click);
            // 
            // Btn_altcizili
            // 
            this.Btn_altcizili.Location = new System.Drawing.Point(204, 72);
            this.Btn_altcizili.Name = "Btn_altcizili";
            this.Btn_altcizili.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            this.Btn_altcizili.Size = new System.Drawing.Size(95, 32);
            this.Btn_altcizili.TabIndex = 3;
            this.Btn_altcizili.Text = "Altı Çizili";
            this.Btn_altcizili.UseVisualStyleBackColor = true;
            this.Btn_altcizili.Click += new System.EventHandler(this.Btn_altcizili_Click);
            // 
            // Btn_ustucizili
            // 
            this.Btn_ustucizili.Location = new System.Drawing.Point(305, 72);
            this.Btn_ustucizili.Name = "Btn_ustucizili";
            this.Btn_ustucizili.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout);
            this.Btn_ustucizili.Size = new System.Drawing.Size(97, 32);
            this.Btn_ustucizili.TabIndex = 4;
            this.Btn_ustucizili.Text = "Üstü Çizili";
            this.Btn_ustucizili.UseVisualStyleBackColor = true;
            this.Btn_ustucizili.Click += new System.EventHandler(this.Btn_ustucizili_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.TabIndex = 5;
            this.label1.Text = "Boyut:";
            // 
            // numericUpDown_boyut
            // 
            this.numericUpDown_boyut.Location = new System.Drawing.Point(60, 119);
            this.numericUpDown_boyut.Name = "numericUpDown_boyut";
            this.numericUpDown_boyut.Minimum = 6;
            this.numericUpDown_boyut.Maximum = 72;
            this.numericUpDown_boyut.Value = new decimal(new int[] { 14, 0, 0, 0 });
            this.numericUpDown_boyut.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_boyut.TabIndex = 6;
            this.numericUpDown_boyut.ValueChanged += new System.EventHandler(this.numericUpDown_boyut_ValueChanged);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(140, 116);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(160, 30);
            this.Btn_reset.TabIndex = 7;
            this.Btn_reset.Text = "ResetFont";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.ForeColor = Color.DimGray;
            this.label2.Size = new System.Drawing.Size(390, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.numericUpDown_boyut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ustucizili);
            this.Controls.Add(this.Btn_altcizili);
            this.Controls.Add(this.Btn_egik);
            this.Controls.Add(this.Btn_kalin);
            this.Controls.Add(this.Txt_yazi);
            this.Name = "Form1";
            this.Text = "Font İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_boyut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_yazi;
        private System.Windows.Forms.Button Btn_kalin;
        private System.Windows.Forms.Button Btn_egik;
        private System.Windows.Forms.Button Btn_altcizili;
        private System.Windows.Forms.Button Btn_ustucizili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_boyut;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Label label2;
    }
}
