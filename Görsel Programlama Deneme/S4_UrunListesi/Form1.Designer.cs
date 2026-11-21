namespace S4_UrunListesi
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnShowTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün adı:";

            this.txtProductName.Location = new System.Drawing.Point(85, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(175, 20);
            this.txtProductName.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı (TL):";

            this.txtProductPrice.Location = new System.Drawing.Point(85, 38);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(175, 20);
            this.txtProductPrice.TabIndex = 3;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);

            this.btnAddProduct.Location = new System.Drawing.Point(270, 11);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 48);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Ürünü Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(15, 70);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(375, 160);
            this.lstProducts.TabIndex = 5;

            this.btnShowTotal.Location = new System.Drawing.Point(15, 238);
            this.btnShowTotal.Name = "btnShowTotal";
            this.btnShowTotal.Size = new System.Drawing.Size(175, 28);
            this.btnShowTotal.TabIndex = 6;
            this.btnShowTotal.Text = "Listele ve Toplamı Göster";
            this.btnShowTotal.UseVisualStyleBackColor = true;
            this.btnShowTotal.Click += new System.EventHandler(this.btnShowTotal_Click);

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(200, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Toplam Tutar: 0,00 TL";

            this.AcceptButton = this.btnAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 280);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnShowTotal);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ürün Listesi ve Toplam Tutar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnShowTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}
