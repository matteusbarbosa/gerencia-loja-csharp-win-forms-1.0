namespace TP2
{
    partial class ReportStockLocal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_shop_name = new System.Windows.Forms.Label();
            this.tv_list_products_specific = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de estoque da loja:";
            // 
            // lb_shop_name
            // 
            this.lb_shop_name.AutoSize = true;
            this.lb_shop_name.Location = new System.Drawing.Point(158, 13);
            this.lb_shop_name.Name = "lb_shop_name";
            this.lb_shop_name.Size = new System.Drawing.Size(55, 13);
            this.lb_shop_name.TabIndex = 1;
            this.lb_shop_name.Text = "NomeLoja";
            // 
            // tv_list_products_specific
            // 
            this.tv_list_products_specific.Location = new System.Drawing.Point(16, 43);
            this.tv_list_products_specific.Name = "tv_list_products_specific";
            this.tv_list_products_specific.Size = new System.Drawing.Size(256, 196);
            this.tv_list_products_specific.TabIndex = 2;
            // 
            // ReportStockLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tv_list_products_specific);
            this.Controls.Add(this.lb_shop_name);
            this.Controls.Add(this.label1);
            this.Name = "ReportStockLocal";
            this.Text = "Estoque Local";
            this.Load += new System.EventHandler(this.ReportStockLocal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_shop_name;
        private System.Windows.Forms.TreeView tv_list_products_specific;
    }
}