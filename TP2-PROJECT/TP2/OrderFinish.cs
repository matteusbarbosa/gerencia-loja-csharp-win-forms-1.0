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
    public partial class OrderFinish : Form {
        public Order OrderData { get; set; }
        public DataSource DatabaseSource { get; set; }

        public OrderFinish() {
            InitializeComponent();
        }

        public OrderFinish(DataSource ds, Order Order) {
            OrderData = Order;
            DatabaseSource = ds;
            InitializeComponent();
        }

        private void OrderFinish_Load(object sender, EventArgs e) {
            foreach (Product p in OrderData.Items) {
                tv_list_order.Nodes.Add(p.Name + " | Loja: " + p.Stock.Shop.Name);
            }
            if (OrderData.Delivery is DeliverySedex) {
                DeliverySedex ds = new DeliverySedex();
                OrderData.PriceTotal += (OrderData.PriceTotal * DeliverySedex.TaxOverPrice);
                lb_price_total.Text = "" + (OrderData.PriceTotal);
            }
            foreach (Shop s in DatabaseSource.ShopList) {
                cmb_shop_list.Items.Add(s.Name);
            }
            lb_delivery_tax.Text = "" + (OrderData.PriceTotal * DeliverySedex.TaxOverPrice);
        }

        private void bt_order_finish_Click(object sender, EventArgs e) {
            try {
                Order o = new Order();
                double PriceFinal = OrderData.PriceTotal;
                double v = PriceFinal;
                o.TesteException(v);
                String finalMessage;
                finalMessage = "Compra finalizada! \n";
                if (cmb_shop_list.SelectedItem != null) {
                    PriceFinal -= double.Parse(lb_delivery_tax.Text);
                    finalMessage += " \n Busque seu produto na loja " + cmb_shop_list.SelectedItem;
                }
                else                
                    finalMessage += "\n Seu produto será entregue via SEDEX.";                
                OrderData.PriceFinal = PriceFinal;
                MessageBox.Show(finalMessage + "\n Valor total da fatura a ser pago: R$" + PriceFinal, "Compra realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ExceptionOrderInvalid or1) {
                MessageBox.Show(or1.Message, "Ordem sem valor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_shop_list_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
