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
    public partial class ReportStockLocal : Form {
        public Dictionary<Product, int> Products { get; set; }
        public string ShopName { get; set; }

        public ReportStockLocal(Dictionary<Product, int> products, string shopname) {
            ShopName = shopname;
            Products = products;
            InitializeComponent();
        }

        private void ReportStockLocal_Load(object sender, EventArgs e) {
            tv_list_products_specific.Nodes.Add("Relatório específico por loja");
            lb_shop_name.Text = ShopName;
            foreach (KeyValuePair<Product, int> p in Products) {
                if (p.Value != 0)
                    tv_list_products_specific.Nodes.Add(p.Key.Name + " (" + p.Value + ")");
            }
        }
    }
}
