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
    public partial class ListProducts : Form {
        public Dictionary<Product, int> Products { get; set; }
        public DataSource DataSource { get; set; }

        public ListProducts() {
            InitializeComponent();
        }

        public ListProducts(DataSource ds) {
            Products = Report.StockGlobal(ds);
            DataSource = ds;            
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void ListProducts_Load(object sender, EventArgs e) {
            
            Random rnd = new Random(100);
            Client cl = new Client(rnd.Next());
            cl.Orders = new List<Order>();
            DataSource.ClientList.Add(cl);
            foreach (KeyValuePair<Product, int> p in Products) {                                
                if (p.Value != 0)                
                    cls_products.Items.Add(p.Key.Name);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Order o = new Order();
                o.Items = new Product[cls_products.CheckedItems.Count];                
                o.Delivery = new DeliverySedex();
                o.Buyer = DataSource.ClientList.Last();
                double v;

                int c = 0;
                foreach (string clb in cls_products.CheckedItems) {                    
                    KeyValuePair<Product, int> p = Shop.SearchProduct(Shop.First, clb);                    
                    if (p.Value > 0) {
                        o.Items[c] = p.Key;
                        o.PriceTotal += p.Key.Price;
                        c++;
                    }                    
                }
                v = o.PriceTotal;
                o.TesteException(v);
                DataSource.ClientList.Last().Orders.Add(o);                
                OrderFinish orf = new OrderFinish(DataSource, o);
                orf.Show();
            }
            catch (ExceptionOrderInvalid pt) {
                MessageBox.Show(pt.Message, "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void cls_products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
