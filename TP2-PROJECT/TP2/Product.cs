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
    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public Stock Stock { get; set; }
        double PricePromotional { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, double pricepromo) : this(name, price) {
            PricePromotional = pricepromo;
        }
    }
}
