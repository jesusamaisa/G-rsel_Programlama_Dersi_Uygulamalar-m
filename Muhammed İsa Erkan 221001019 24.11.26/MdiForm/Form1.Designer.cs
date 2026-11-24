namespace MdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereGoruntusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayDoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyDoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basamaklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeleriYerlestirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dosyaToolStripMenuItem, this.pencereToolStripMenuItem, this.pencereGoruntusuToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.MdiWindowListItem = this.pencereToolStripMenuItem;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.yeniToolStripMenuItem, this.kapatToolStripMenuItem });
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.N);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // pencereToolStripMenuItem
            // 
            this.pencereToolStripMenuItem.Name = "pencereToolStripMenuItem";
            this.pencereToolStripMenuItem.Text = "Pencere";
            // 
            // pencereGoruntusuToolStripMenuItem
            // 
            this.pencereGoruntusuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.yatayDoseToolStripMenuItem, this.dikeyDoseToolStripMenuItem, this.basamaklaToolStripMenuItem, this.simgeleriYerlestirToolStripMenuItem });
            this.pencereGoruntusuToolStripMenuItem.Name = "pencereGoruntusuToolStripMenuItem";
            this.pencereGoruntusuToolStripMenuItem.Text = "Pencere Görüntüsü";
            // 
            // yatayDoseToolStripMenuItem
            // 
            this.yatayDoseToolStripMenuItem.Name = "yatayDoseToolStripMenuItem";
            this.yatayDoseToolStripMenuItem.Text = "Yatay Döşe";
            this.yatayDoseToolStripMenuItem.Click += new System.EventHandler(this.yatayDoseToolStripMenuItem_Click);
            // 
            // dikeyDoseToolStripMenuItem
            // 
            this.dikeyDoseToolStripMenuItem.Name = "dikeyDoseToolStripMenuItem";
            this.dikeyDoseToolStripMenuItem.Text = "Dikey Döşe";
            this.dikeyDoseToolStripMenuItem.Click += new System.EventHandler(this.dikeyDoseToolStripMenuItem_Click);
            // 
            // basamaklaToolStripMenuItem
            // 
            this.basamaklaToolStripMenuItem.Name = "basamaklaToolStripMenuItem";
            this.basamaklaToolStripMenuItem.Text = "Basamakla";
            this.basamaklaToolStripMenuItem.Click += new System.EventHandler(this.basamaklaToolStripMenuItem_Click);
            // 
            // simgeleriYerlestirToolStripMenuItem
            // 
            this.simgeleriYerlestirToolStripMenuItem.Name = "simgeleriYerlestirToolStripMenuItem";
            this.simgeleriYerlestirToolStripMenuItem.Text = "Simgeleri Yerleştir";
            this.simgeleriYerlestirToolStripMenuItem.Click += new System.EventHandler(this.simgeleriYerlestirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.IsMdiContainer = true;
            this.Text = "Muhammed İsa Erkan 221001019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereGoruntusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayDoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyDoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basamaklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeleriYerlestirToolStripMenuItem;
    }
}
