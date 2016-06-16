namespace TP2
{
    partial class SearchProduct
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
            this.lb_search_product = new System.Windows.Forms.Label();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lb_search_result = new System.Windows.Forms.Label();
            this.lb_result_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_search_product
            // 
            this.lb_search_product.AutoSize = true;
            this.lb_search_product.Location = new System.Drawing.Point(13, 18);
            this.lb_search_product.Name = "lb_search_product";
            this.lb_search_product.Size = new System.Drawing.Size(129, 13);
            this.lb_search_product.TabIndex = 0;
            this.lb_search_product.Text = "Buscar produto por nome:";
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(16, 43);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(229, 20);
            this.tbx_search.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(251, 42);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "&OK >>";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // lb_search_result
            // 
            this.lb_search_result.AutoSize = true;
            this.lb_search_result.Location = new System.Drawing.Point(127, 86);
            this.lb_search_result.Name = "lb_search_result";
            this.lb_search_result.Size = new System.Drawing.Size(55, 13);
            this.lb_search_result.TabIndex = 3;
            this.lb_search_result.Text = "Resultado";
            this.lb_search_result.Click += new System.EventHandler(this.lb_search_result_Click);
            // 
            // lb_result_title
            // 
            this.lb_result_title.AutoSize = true;
            this.lb_result_title.Location = new System.Drawing.Point(16, 86);
            this.lb_result_title.Name = "lb_result_title";
            this.lb_result_title.Size = new System.Drawing.Size(105, 13);
            this.lb_result_title.TabIndex = 4;
            this.lb_result_title.Text = "Resultado da busca:";
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 142);
            this.Controls.Add(this.lb_result_title);
            this.Controls.Add(this.lb_search_result);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.lb_search_product);
            this.Name = "SearchProduct";
            this.Text = "Busca de Produtos";
            this.Load += new System.EventHandler(this.SearchProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_search_product;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label lb_search_result;
        private System.Windows.Forms.Label lb_result_title;
    }
}