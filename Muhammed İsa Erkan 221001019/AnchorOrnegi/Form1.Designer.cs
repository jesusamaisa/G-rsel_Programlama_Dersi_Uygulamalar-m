namespace AnchorOrnegi
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
            this.panel_ust = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_sol = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_sag = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel_ust.SuspendLayout();
            this.panel_sol.SuspendLayout();
            this.panel_sag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ust
            // 
            this.panel_ust.Controls.Add(this.button1);
            this.panel_ust.Controls.Add(this.button2);
            this.panel_ust.Controls.Add(this.button3);
            this.panel_ust.Location = new System.Drawing.Point(90, 12);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.BorderStyle = BorderStyle.FixedSingle;
            this.panel_ust.Size = new System.Drawing.Size(280, 50);
            this.panel_ust.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 8);
            this.button1.Name = "button1";
            this.button1.BackColor = Color.Red;
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kırmızı";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 8);
            this.button2.Name = "button2";
            this.button2.BackColor = Color.LimeGreen;
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yeşil";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 8);
            this.button3.Name = "button3";
            this.button3.BackColor = Color.DodgerBlue;
            this.button3.Size = new System.Drawing.Size(80, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mavi";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel_sol
            // 
            this.panel_sol.Controls.Add(this.button4);
            this.panel_sol.Controls.Add(this.button5);
            this.panel_sol.Location = new System.Drawing.Point(12, 12);
            this.panel_sol.Name = "panel_sol";
            this.panel_sol.BorderStyle = BorderStyle.FixedSingle;
            this.panel_sol.Size = new System.Drawing.Size(70, 270);
            this.panel_sol.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 8);
            this.button4.Name = "button4";
            this.button4.BackColor = Color.Gold;
            this.button4.Size = new System.Drawing.Size(56, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sarı";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 56);
            this.button5.Name = "button5";
            this.button5.Font = new Font("Segoe UI", 7.5F);
            this.button5.BackColor = Color.Orange;
            this.button5.Size = new System.Drawing.Size(56, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "Turuncu";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel_sag
            // 
            this.panel_sag.Controls.Add(this.button6);
            this.panel_sag.Controls.Add(this.button7);
            this.panel_sag.Location = new System.Drawing.Point(378, 12);
            this.panel_sag.Name = "panel_sag";
            this.panel_sag.BorderStyle = BorderStyle.FixedSingle;
            this.panel_sag.Size = new System.Drawing.Size(70, 270);
            this.panel_sag.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 8);
            this.button6.Name = "button6";
            this.button6.BackColor = Color.MediumPurple;
            this.button6.Size = new System.Drawing.Size(56, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "Mor";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 56);
            this.button7.Name = "button7";
            this.button7.BackColor = Color.HotPink;
            this.button7.Size = new System.Drawing.Size(56, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "Pembe";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Multiline = true;
            this.textBox1.Size = new System.Drawing.Size(280, 212);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Formun boyutunu değiştirerek kontrollerin davranışını inceleyiniz.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Checked = true;
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Anchor ayarları aktif";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_sag);
            this.Controls.Add(this.panel_sol);
            this.Controls.Add(this.panel_ust);
            this.Name = "Form1";
            this.Text = "Anchor Özelliği";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            this.panel_sol.ResumeLayout(false);
            this.panel_sol.PerformLayout();
            this.panel_sag.ResumeLayout(false);
            this.panel_sag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_sol;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_sag;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
