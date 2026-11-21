namespace KonumBoyutAyari
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
            this.numericUpDown_sol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_ust = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_genislik = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_yukseklik = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yukseklik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Sol";
            // 
            // numericUpDown_sol
            // 
            this.numericUpDown_sol.Location = new System.Drawing.Point(80, 12);
            this.numericUpDown_sol.Name = "numericUpDown_sol";
            this.numericUpDown_sol.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_sol.TabIndex = 1;
            this.numericUpDown_sol.ValueChanged += new System.EventHandler(this.numericUpDown_sol_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Name = "label2";
            this.label2.TabIndex = 2;
            this.label2.Text = "Üst";
            // 
            // numericUpDown_ust
            // 
            this.numericUpDown_ust.Location = new System.Drawing.Point(200, 12);
            this.numericUpDown_ust.Name = "numericUpDown_ust";
            this.numericUpDown_ust.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_ust.TabIndex = 3;
            this.numericUpDown_ust.ValueChanged += new System.EventHandler(this.numericUpDown_ust_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 15);
            this.label3.Name = "label3";
            this.label3.TabIndex = 4;
            this.label3.Text = "Genişlik";
            // 
            // numericUpDown_genislik
            // 
            this.numericUpDown_genislik.Location = new System.Drawing.Point(340, 12);
            this.numericUpDown_genislik.Name = "numericUpDown_genislik";
            this.numericUpDown_genislik.Size = new System.Drawing.Size(70, 23);
            this.numericUpDown_genislik.TabIndex = 5;
            this.numericUpDown_genislik.ValueChanged += new System.EventHandler(this.numericUpDown_genislik_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 15);
            this.label4.Name = "label4";
            this.label4.TabIndex = 6;
            this.label4.Text = "Yükseklik";
            // 
            // numericUpDown_yukseklik
            // 
            this.numericUpDown_yukseklik.Location = new System.Drawing.Point(485, 12);
            this.numericUpDown_yukseklik.Name = "numericUpDown_yukseklik";
            this.numericUpDown_yukseklik.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown_yukseklik.TabIndex = 7;
            this.numericUpDown_yukseklik.ValueChanged += new System.EventHandler(this.numericUpDown_yukseklik_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 60);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Beni taşı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown_yukseklik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_genislik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_ust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_sol);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konum ve Boyut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yukseklik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_sol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_ust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_genislik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_yukseklik;
        private System.Windows.Forms.TextBox textBox1;
    }
}
