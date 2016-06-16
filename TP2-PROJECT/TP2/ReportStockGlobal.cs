using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Autor: Matteus Barbosa dos Santos
    Instituição: PUC Minas - Barreiro
    Contato: contato@desenvolvedormatteus.com.br
    Website: https://www.desenvolvedormatteus.com.br
    Última atualização: Junho de 2016
    Licença: Livre para uso comercial
*/

namespace TP2
{
    public partial class ReportStockGlobal : Form {
        public Dictionary<Product, int> Products { get; set; }

        public ReportStockGlobal(Dictionary<Product, int> products) {
            Products = products;
            InitializeComponent();
        }

        private void ReportStockGlobal_Load(object sender, EventArgs e) {
            tv_list_products_all.Nodes.Add("Relatório Geral");
            foreach (KeyValuePair<Product, int> p in Products) {
                if (p.Value != 0)
                    tv_list_products_all.Nodes.Add(p.Key.Name+" ("+p.Value+")");
            }
        }

        private void cls_products_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
