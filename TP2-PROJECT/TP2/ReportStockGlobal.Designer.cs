﻿namespace TP2
{
    partial class ReportStockGlobal
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
            this.tv_list_products_all = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv_list_products_all
            // 
            this.tv_list_products_all.Location = new System.Drawing.Point(13, 13);
            this.tv_list_products_all.Name = "tv_list_products_all";
            this.tv_list_products_all.Size = new System.Drawing.Size(259, 236);
            this.tv_list_products_all.TabIndex = 0;
            // 
            // ReportStockGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tv_list_products_all);
            this.Name = "ReportStockGlobal";
            this.Text = "Estoque Global";
            this.Load += new System.EventHandler(this.ReportStockGlobal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_list_products_all;
    }
}