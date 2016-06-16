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
    public partial class ShopReportSelect : Form
    {
        public DataSource DataSource { get; set; }
        public ShopReportSelect(DataSource ds)
        {
            DataSource = ds;
            InitializeComponent();
        }

        private void ShopReportSelect_Load(object sender, EventArgs e)
        {            
            foreach (Shop s in DataSource.ShopList)
            {
                cmb_shop_list.Items.Add(s.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportStockLocal rsl = new ReportStockLocal(Report.StockLocal(DataSource, cmb_shop_list.Text), cmb_shop_list.Text);
            rsl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
