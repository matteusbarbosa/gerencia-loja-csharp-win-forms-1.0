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
    public partial class ReportSelling : Form {
        public DataSource DataSource { get; set; }

        public ReportSelling(DataSource ds) {
            DataSource = ds;
            InitializeComponent();
        }

        public void TestaExceptionVendas() {
            if (DataSource.ClientList.Count == 0)
                throw new ExceptionReportInvalid("Nenhuma venda foi realizada para carregar o relatório.");
        }

        private void ReportSelling_Load(object sender, EventArgs e) {
            foreach (Order o in DataSource.ClientList.Last().Orders) {
                TreeNode tvi = tv_orders_list.Nodes.Add(" Cliente [" + o.Buyer.Number + "] = R$" + o.PriceFinal);
                foreach (Product p in o.Items)
                    tvi.Nodes.Add(p.Name);
            }
        }
    }
}
