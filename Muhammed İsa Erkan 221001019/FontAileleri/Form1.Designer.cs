namespace FontAileleri
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
            this.listBox_fontlar = new System.Windows.Forms.ListBox();
            this.Txt_yazi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_fontlar
            // 
            this.listBox_fontlar.Location = new System.Drawing.Point(12, 12);
            this.listBox_fontlar.Name = "listBox_fontlar";
            this.listBox_fontlar.ItemHeight = 15;
            this.listBox_fontlar.Size = new System.Drawing.Size(200, 394);
            this.listBox_fontlar.TabIndex = 0;
            this.listBox_fontlar.SelectedIndexChanged += new System.EventHandler(this.listBox_fontlar_SelectedIndexChanged);
            // 
            // Txt_yazi
            // 
            this.Txt_yazi.Location = new System.Drawing.Point(222, 12);
            this.Txt_yazi.Name = "Txt_yazi";
            this.Txt_yazi.Multiline = true;
            this.Txt_yazi.Size = new System.Drawing.Size(325, 80);
            this.Txt_yazi.TabIndex = 1;
            this.Txt_yazi.Text = "Muhammed İsa Erkan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tüm fontları formda göster (Paint)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_yazi);
            this.Controls.Add(this.listBox_fontlar);
            this.Name = "Form1";
            this.Text = "Font Aileleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_fontlar;
        private System.Windows.Forms.TextBox Txt_yazi;
        private System.Windows.Forms.Button button1;
    }
}
