using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Autor: Matteus Barbosa dos Santos
    Instituição: PUC Minas - Barreiro
    Contato: contato@desenvolvedormatteus.com.br
    Website: https://www.desenvolvedormatteus.com.br
    Última atualização: Junho de 2016
    Licença: Livre para uso comercial
*/

namespace TP2
{
    class Report {
        public static Dictionary<Product, int> ResultsSelling;
        public static Dictionary<Product, int> ResultsStockGlobal;
        public static Dictionary<Product, int> ResultsStockLocal;

        /* Entregue três tipos de relatórios
         */

        /* Vendas 
         * Um relatório com todos os produtos vendidos e o faturamento total naquela sessão.
         */
        public void Selling(DataSource ds) { }

        /* Estoque (local)
         * Relatório de estoque de uma loja
         */
        public static Dictionary<Product, int> StockLocal(DataSource ds, string shopsearch) {
            ResultsStockLocal = new Dictionary<Product, int>();

            if (ds.ShopList == null) {
                throw new ExceptionShopInvalid("Lista de lojas fornecida é inválida.");
            }
            foreach (Shop sp in ds.ShopList) {
                if (shopsearch != sp.Name)
                    continue;                
                foreach (KeyValuePair<Product, int> pd in sp.st.Items)
                    ResultsStockLocal.Add(pd.Key, pd.Value);                
            }
            return ResultsStockLocal;
        }

        /* Estoque (geral)
         * Exibe todos os estoques de todas as lojas.
         */
        public static Dictionary<Product, int> StockGlobal(DataSource ds) {
            ResultsStockGlobal = new Dictionary<Product, int>();

            if (ds.ShopList == null) {
                throw new ExceptionShopInvalid("Lista de lojas fornecida é inválida.");
            }
            foreach (Shop sp in ds.ShopList) {
                foreach (KeyValuePair<Product, int> pd in sp.st.Items)                
                    ResultsStockGlobal.Add(pd.Key, pd.Value);                
            }
            return ResultsStockGlobal;
        }
    }
}
