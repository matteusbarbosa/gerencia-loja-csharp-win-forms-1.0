namespace TP2
{
    partial class ReportSelling
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
            this.tv_orders_list = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv_orders_list
            // 
            this.tv_orders_list.Location = new System.Drawing.Point(12, 12);
            this.tv_orders_list.Name = "tv_orders_list";
            this.tv_orders_list.Size = new System.Drawing.Size(260, 237);
            this.tv_orders_list.TabIndex = 0;
            // 
            // ReportSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tv_orders_list);
            this.Name = "ReportSelling";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.ReportSelling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_orders_list;
    }
}