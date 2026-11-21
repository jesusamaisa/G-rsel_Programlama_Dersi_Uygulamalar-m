namespace U068_RgbRenkAyari
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1_red = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2_green = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3_blue = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_blue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Kırmızı";
            // 
            // numericUpDown1_red
            // 
            this.numericUpDown1_red.Location = new System.Drawing.Point(80, 15);
            this.numericUpDown1_red.Name = "numericUpDown1_red";
            this.numericUpDown1_red.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown1_red.TabIndex = 1;
            this.numericUpDown1_red.ValueChanged += new System.EventHandler(this.renk_degisti);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeşil";
            // 
            // numericUpDown2_green
            // 
            this.numericUpDown2_green.Location = new System.Drawing.Point(80, 49);
            this.numericUpDown2_green.Name = "numericUpDown2_green";
            this.numericUpDown2_green.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown2_green.TabIndex = 3;
            this.numericUpDown2_green.ValueChanged += new System.EventHandler(this.renk_degisti);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.TabIndex = 4;
            this.label3.Text = "Mavi";
            // 
            // numericUpDown3_blue
            // 
            this.numericUpDown3_blue.Location = new System.Drawing.Point(80, 83);
            this.numericUpDown3_blue.Name = "numericUpDown3_blue";
            this.numericUpDown3_blue.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown3_blue.TabIndex = 5;
            this.numericUpDown3_blue.ValueChanged += new System.EventHandler(this.renk_degisti);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(165, 12);
            this.panel1.Name = "panel1";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Size = new System.Drawing.Size(150, 170);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "RGB(0, 0, 0)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown3_blue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2_green);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1_red);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "RGB Renk Ayarı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3_blue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_red;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2_green;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3_blue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}
