namespace TP2
{
    partial class ListProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_sedex_buy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cls_products = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // bt_sedex_buy
            // 
            this.bt_sedex_buy.Location = new System.Drawing.Point(128, 322);
            this.bt_sedex_buy.Name = "bt_sedex_buy";
            this.bt_sedex_buy.Size = new System.Drawing.Size(144, 23);
            this.bt_sedex_buy.TabIndex = 1;
            this.bt_sedex_buy.Text = "&Pagamento e entrega >>";
            this.bt_sedex_buy.UseVisualStyleBackColor = true;
            this.bt_sedex_buy.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produtos disponíveis:";
            // 
            // cls_products
            // 
            this.cls_products.FormattingEnabled = true;
            this.cls_products.Location = new System.Drawing.Point(15, 37);
            this.cls_products.Name = "cls_products";
            this.cls_products.Size = new System.Drawing.Size(257, 274);
            this.cls_products.TabIndex = 5;
            this.cls_products.SelectedIndexChanged += new System.EventHandler(this.cls_products_SelectedIndexChanged);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 357);
            this.Controls.Add(this.cls_products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_sedex_buy);
            this.Name = "ListProducts";
            this.Text = "Loja Virtual";
            this.Load += new System.EventHandler(this.ListProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_sedex_buy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cls_products;
    }
}