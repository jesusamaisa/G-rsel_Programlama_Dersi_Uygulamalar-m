namespace S3_ScrollBarRenk
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioGroup1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sb1 = new System.Windows.Forms.HScrollBar();
            this.sb2 = new System.Windows.Forms.HScrollBar();
            this.sb3 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.RadioGroup1.SuspendLayout();
            this.SuspendLayout();

            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 90);
            this.panel1.TabIndex = 0;

            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muhammed İsa Erkan 221001019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.RadioGroup1.Controls.Add(this.radioButton1);
            this.RadioGroup1.Controls.Add(this.radioButton2);
            this.RadioGroup1.Location = new System.Drawing.Point(12, 112);
            this.RadioGroup1.Name = "RadioGroup1";
            this.RadioGroup1.Size = new System.Drawing.Size(360, 52);
            this.RadioGroup1.TabIndex = 1;
            this.RadioGroup1.TabStop = false;
            this.RadioGroup1.Text = "Rengi değişecek yer";

            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Zemin rengi";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.secim_degisti);

            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Yazı rengi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.secim_degisti);

            this.sb1.Location = new System.Drawing.Point(12, 180);
            this.sb1.Maximum = 264;
            this.sb1.Name = "sb1";
            this.sb1.Size = new System.Drawing.Size(250, 20);
            this.sb1.TabIndex = 2;
            this.sb1.Value = 255;
            this.sb1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.renk_degisti);

            this.sb2.Location = new System.Drawing.Point(12, 212);
            this.sb2.Maximum = 264;
            this.sb2.Name = "sb2";
            this.sb2.Size = new System.Drawing.Size(250, 20);
            this.sb2.TabIndex = 3;
            this.sb2.Value = 255;
            this.sb2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.renk_degisti);

            this.sb3.Location = new System.Drawing.Point(12, 244);
            this.sb3.Maximum = 264;
            this.sb3.Name = "sb3";
            this.sb3.Size = new System.Drawing.Size(250, 20);
            this.sb3.TabIndex = 4;
            this.sb3.Value = 255;
            this.sb3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.renk_degisti);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kırmızı: 255";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeşil: 255";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mavi: 255";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sb3);
            this.Controls.Add(this.sb2);
            this.Controls.Add(this.sb1);
            this.Controls.Add(this.RadioGroup1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ScrollBar ile Zemin ve Yazı Rengi";
            this.panel1.ResumeLayout(false);
            this.RadioGroup1.ResumeLayout(false);
            this.RadioGroup1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox RadioGroup1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.HScrollBar sb1;
        private System.Windows.Forms.HScrollBar sb2;
        private System.Windows.Forms.HScrollBar sb3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
