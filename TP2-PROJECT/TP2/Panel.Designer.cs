namespace TP2
{
    partial class Panel
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
            this.stock_length_label = new System.Windows.Forms.Label();
            this.stock_length_value = new System.Windows.Forms.Label();
            this.shop_phisical_length_label = new System.Windows.Forms.Label();
            this.shop_phisical_length_value = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lojaVirtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stock_length_label
            // 
            this.stock_length_label.AutoSize = true;
            this.stock_length_label.Location = new System.Drawing.Point(16, 79);
            this.stock_length_label.Name = "stock_length_label";
            this.stock_length_label.Size = new System.Drawing.Size(109, 13);
            this.stock_length_label.TabIndex = 2;
            this.stock_length_label.Text = "Produtos disponíveis:";
            // 
            // stock_length_value
            // 
            this.stock_length_value.AutoSize = true;
            this.stock_length_value.Location = new System.Drawing.Point(153, 79);
            this.stock_length_value.Name = "stock_length_value";
            this.stock_length_value.Size = new System.Drawing.Size(31, 13);
            this.stock_length_value.TabIndex = 3;
            this.stock_length_value.Text = "Valor";
            // 
            // shop_phisical_length_label
            // 
            this.shop_phisical_length_label.AutoSize = true;
            this.shop_phisical_length_label.Location = new System.Drawing.Point(16, 44);
            this.shop_phisical_length_label.Name = "shop_phisical_length_label";
            this.shop_phisical_length_label.Size = new System.Drawing.Size(129, 13);
            this.shop_phisical_length_label.TabIndex = 4;
            this.shop_phisical_length_label.Text = "Lojas Físicas disponíveis:";
            // 
            // shop_phisical_length_value
            // 
            this.shop_phisical_length_value.AutoSize = true;
            this.shop_phisical_length_value.Location = new System.Drawing.Point(153, 44);
            this.shop_phisical_length_value.Name = "shop_phisical_length_value";
            this.shop_phisical_length_value.Size = new System.Drawing.Size(31, 13);
            this.shop_phisical_length_value.TabIndex = 5;
            this.shop_phisical_length_value.Text = "Valor";
            this.shop_phisical_length_value.Click += new System.EventHandler(this.shop_phisical_length_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaVirtualToolStripMenuItem,
            this.buscarProdutoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lojaVirtualToolStripMenuItem
            // 
            this.lojaVirtualToolStripMenuItem.Name = "lojaVirtualToolStripMenuItem";
            this.lojaVirtualToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.lojaVirtualToolStripMenuItem.Text = "&Loja Virtual";
            this.lojaVirtualToolStripMenuItem.Click += new System.EventHandler(this.lojaVirtualToolStripMenuItem_Click);
            // 
            // buscarProdutoToolStripMenuItem
            // 
            this.buscarProdutoToolStripMenuItem.Name = "buscarProdutoToolStripMenuItem";
            this.buscarProdutoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.buscarProdutoToolStripMenuItem.Text = "&Buscar Produto";
            this.buscarProdutoToolStripMenuItem.Click += new System.EventHandler(this.buscarProdutoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.geralToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.localToolStripMenuItem.Text = "&Local";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.geralToolStripMenuItem.Text = "&Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shop_phisical_length_value);
            this.Controls.Add(this.shop_phisical_length_label);
            this.Controls.Add(this.stock_length_value);
            this.Controls.Add(this.stock_length_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.Text = "Trabalho Prático 2 (Loja)";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stock_length_label;
        private System.Windows.Forms.Label stock_length_value;
        private System.Windows.Forms.Label shop_phisical_length_label;
        private System.Windows.Forms.Label shop_phisical_length_value;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaVirtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}