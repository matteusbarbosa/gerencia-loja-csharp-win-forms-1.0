namespace TP2
{
    partial class OrderFinish
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_price_total = new System.Windows.Forms.Label();
            this.lb_delivery_tax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_shop_list = new System.Windows.Forms.ComboBox();
            this.bt_order_finish = new System.Windows.Forms.Button();
            this.tv_list_order = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itens adquiridos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Taxa de entrega:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_price_total
            // 
            this.lb_price_total.AutoSize = true;
            this.lb_price_total.Location = new System.Drawing.Point(171, 39);
            this.lb_price_total.Name = "lb_price_total";
            this.lb_price_total.Size = new System.Drawing.Size(35, 13);
            this.lb_price_total.TabIndex = 4;
            this.lb_price_total.Text = "label4";
            // 
            // lb_delivery_tax
            // 
            this.lb_delivery_tax.AutoSize = true;
            this.lb_delivery_tax.Location = new System.Drawing.Point(171, 10);
            this.lb_delivery_tax.Name = "lb_delivery_tax";
            this.lb_delivery_tax.Size = new System.Drawing.Size(35, 13);
            this.lb_delivery_tax.TabIndex = 5;
            this.lb_delivery_tax.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ou busque na loja (sem taxa SEDEX):";
            // 
            // cmb_shop_list
            // 
            this.cmb_shop_list.FormattingEnabled = true;
            this.cmb_shop_list.Location = new System.Drawing.Point(16, 316);
            this.cmb_shop_list.Name = "cmb_shop_list";
            this.cmb_shop_list.Size = new System.Drawing.Size(256, 21);
            this.cmb_shop_list.TabIndex = 7;
            this.cmb_shop_list.SelectedIndexChanged += new System.EventHandler(this.cmb_shop_list_SelectedIndexChanged);
            // 
            // bt_order_finish
            // 
            this.bt_order_finish.Location = new System.Drawing.Point(171, 350);
            this.bt_order_finish.Name = "bt_order_finish";
            this.bt_order_finish.Size = new System.Drawing.Size(101, 23);
            this.bt_order_finish.TabIndex = 8;
            this.bt_order_finish.Text = "&Finalizar compra";
            this.bt_order_finish.UseVisualStyleBackColor = true;
            this.bt_order_finish.Click += new System.EventHandler(this.bt_order_finish_Click);
            // 
            // tv_list_order
            // 
            this.tv_list_order.Location = new System.Drawing.Point(13, 39);
            this.tv_list_order.Name = "tv_list_order";
            this.tv_list_order.Size = new System.Drawing.Size(259, 172);
            this.tv_list_order.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R$";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_price_total);
            this.panel1.Controls.Add(this.lb_delivery_tax);
            this.panel1.Location = new System.Drawing.Point(13, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 59);
            this.panel1.TabIndex = 12;
            // 
            // OrderFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tv_list_order);
            this.Controls.Add(this.bt_order_finish);
            this.Controls.Add(this.cmb_shop_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "OrderFinish";
            this.Text = "Finalizado compra";
            this.Load += new System.EventHandler(this.OrderFinish_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_price_total;
        private System.Windows.Forms.Label lb_delivery_tax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_shop_list;
        private System.Windows.Forms.Button bt_order_finish;
        private System.Windows.Forms.TreeView tv_list_order;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}