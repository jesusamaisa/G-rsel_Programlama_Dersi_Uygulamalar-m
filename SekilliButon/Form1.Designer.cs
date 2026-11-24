namespace SekilliButon
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.button1.Location = new System.Drawing.Point(20, 30);
            this.button1.Name = "button1";
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yuvarlak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dugme_Click);

            this.button2.Location = new System.Drawing.Point(130, 30);
            this.button2.Name = "button2";
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Size = new System.Drawing.Size(180, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "Elips Düğme";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.dugme_Click);

            this.button3.Location = new System.Drawing.Point(20, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Normal düğme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dugme_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Muhammed İsa Erkan 221001019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
