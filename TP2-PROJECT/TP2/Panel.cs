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
    public partial class Panel : Form {
        private DataSource DataSource;

        public Panel() {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e) {
            try {
                DataSource = new DataSource();                
                DataSource.Read();
                DataSource.ClientList = new List<Client>();
                shop_phisical_length_value.Text = "" + DataSource.ShopList.Count;
                stock_length_value.Text = "" + DataSource.ITENS_AMOUNT;
            }
            catch (NullReferenceException nr) {
                MessageBox.Show(nr.Message.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void shop_phisical_length_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) {
            ReportSelling rs = new ReportSelling(DataSource);
            rs.Show();
        }

        private void btn_report_general_Click(object sender, EventArgs e) {
            ReportStockGlobal rsg = new ReportStockGlobal(Report.StockGlobal(DataSource));
            rsg.Show();
        }

        private void btn_report_local_Click(object sender, EventArgs e) {
            ShopReportSelect srp = new ShopReportSelect(DataSource);
            srp.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                ReportSelling rs = new ReportSelling(DataSource);
                rs.TestaExceptionVendas();
                rs.Show();
            }
            catch (ExceptionReportInvalid rp) {
                MessageBox.Show(rp.Message, "Venda não localizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e) {
            ShopReportSelect srp = new ShopReportSelect(DataSource);
            srp.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportStockGlobal rsg = new ReportStockGlobal(Report.StockGlobal(DataSource));
            rsg.Show();
        }

        private void lojaVirtualToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(Report.StockGlobal(DataSource).Count + " Itens carregados.",
                "Carregamento Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListProducts lp = new ListProducts(DataSource);
            lp.Show();
        }

        private void buscarProdutoToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchProduct sp = new SearchProduct();
            sp.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSobre sb = new FrmSobre();
            sb.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
