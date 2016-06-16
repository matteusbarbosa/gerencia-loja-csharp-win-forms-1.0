using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/* 	Autor: Matteus Barbosa dos Santos
	Instituição: PUC Minas - Barreiro
	Contato: contato@desenvolvedormatteus.com.br
	Website: https://www.desenvolvedormatteus.com.br
	Última atualização: Junho de 2016
	Licença: Livre para uso comercial
*/

namespace TP2
{
    public class DataSource {
        //Parâmetro inicial
        public const string path = "../../bin/Debug/STOCK.txt";
        public List<Shop> ShopList { get; set; }
        public List<Client> ClientList { get; set; }
        public int ITENS_AMOUNT = 0;
        private static Shop ShopRead;
        /* Leia o arquivo e entregue uma instância de Stock, junto ao seu vetor de Produtos mapeado */
      
        public void Read() {
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    /* 
                     * #LJ-01
                     * #END-BHCENTRO
                     * #TP-5
                     * PRODUTO2	PREÇO		QUANTIDADE
                     * //File.ReadLines(path).Count()
                     */
                    String line;
                    int c = 0;
                    ShopList = new List<Shop>();

                    while ((line = sr.ReadLine()) != null) {
                        if (line.Contains("#LJ")) {
                            ShopRead = new ShopVirtual();
                            String[] shopname = line.Split('-');
                            ShopRead.Name = shopname[1];
                            continue;
                        }

                        if (line.Contains("#END")) {
                            String[] addressname = line.Split('-');
                            ShopRead.Name = addressname[1];
                            continue;
                        }

                        if (line.Contains("#TP")) {
                            ShopRead.st = new Stock();
                            ShopRead.st.Shop = ShopRead;
                            ShopRead.st.ITENS_AMOUNT = int.Parse(line.Split('-')[1]);
                            ShopRead.st.Items = new Dictionary<Product, int>();

                            if (Shop.Last != null) {
                                if (ShopRead.st.ITENS_AMOUNT >= Shop.Last.st.ITENS_AMOUNT) {
                                    Shop.Last.ShopChildRight = ShopRead;
                                }
                                else {
                                    Shop.Last.ShopChildLeft = ShopRead;
                                }
                            }

                            if (Shop.First == null) {
                                Shop.First = ShopRead;
                            }
                            Shop.Last = ShopRead;
                            ShopList.Add(ShopRead);
                            continue;
                        }
                        String[] productinfo = line.Split('\t');
                        Product p = new Product(productinfo[0], double.Parse(productinfo[1]));
                        p.Stock = ShopRead.st;
                        Shop.Last.st.Last = p;

                        if (Shop.Last.st.First == null) {
                            Shop.Last.st.First = p;
                        }
                        Shop.Last.st.Items.Add(p, int.Parse(productinfo[2]));
                        c++;
                    }
                    ITENS_AMOUNT = c;
                }
            }
            catch (ArgumentNullException ex1) {
                MessageBox.Show(ex1.Message, "Caminho inforreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentNullException("Caminho do arquivo não informado!");
            }
            catch (ArgumentException) {
                throw new ArgumentException("Argumento inválido!");
            }
            catch (FileNotFoundException) {
                throw new FileNotFoundException("O arquivo 'STOCK.txt' não foi encontrado no diretório " + path + ".");
            }
        }
    }
}