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
    public partial class SearchProduct : Form {
        public SearchProduct() {
            InitializeComponent();

            lb_search_result.Visible = false;
        }

        public void TestaExceptionBusca() {
            if (tbx_search.Text == "")            
                throw new BuscaProdutosException("Gentileza digitar um produto a ser pesquisado.");            
        }
        private void bt_search_Click(object sender, EventArgs e) {
            try {
                TestaExceptionBusca();
                KeyValuePair<Product, int> product_find = Shop.SearchProduct(Shop.First, tbx_search.Text);
                if (product_find.Key == null) {
                    lb_search_result.Visible = true;
                    lb_search_result.Text = "Não encontrado!";
                }
                else {
                    lb_search_result.Visible = true;
                    lb_search_result.Text = "Nome: " + product_find.Key.Name + "\nValor: R$ " +
                        product_find.Key.Price + "\nQuantidade: " + product_find.Value;
                }
            }
            catch (BuscaProdutosException bp) {
                MessageBox.Show(bp.Message, "Produto não digitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchProduct_Load(object sender, EventArgs e) { }

        private void lb_search_result_Click(object sender, EventArgs e) { }
    }
}
