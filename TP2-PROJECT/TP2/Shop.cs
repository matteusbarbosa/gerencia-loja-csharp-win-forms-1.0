using System;
using System.Collections.Generic;
using System.IO;
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
    public abstract class Shop {
        public string Name { get; set; }
        public string Address { get; set; }
        public static Shop First { get; set; }
        public static Shop Last { get; set; }
        public Stock st { get; set; }
        public Shop ShopChildLeft { get; set; }
        public Shop ShopChildRight { get; set; }

        public static KeyValuePair<Product, int> SearchProduct(Shop sp, string name) {
            //Ler lojas na árvore binária
            //Ler cada estoque de cada loja
            //Iterar sobre o Dictionary de produtos/quantidades
            //Se encontrar, retorne o keyvaluepair de produtos/quantidades
            
            foreach (KeyValuePair<Product, int> p in sp.st.Items) {
                if (p.Key.Name.Contains(name))
                    return p;                    
            }

            if (sp.ShopChildLeft == null && sp.ShopChildRight == null)
                return default(KeyValuePair<Product, int>);
                if (sp.ShopChildLeft != null)
                return SearchProduct(sp.ShopChildLeft, name);
            else
                return SearchProduct(sp.ShopChildRight, name);
        }
    }
}
