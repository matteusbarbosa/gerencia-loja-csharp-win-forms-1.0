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
    public class Order {
        public Client Buyer { get; set; }
        public Shop Shop { get; set; }
        public DeliveryMethod Delivery { get; set; }
        public Product[] Items { get; set; }
        public double PriceTotal { get; set; }
        public double PriceFinal { get; set; }
        public int ZipcodeOrigin { get; set; }
        public int ZipcodeDestination { get; set; }

        public Order() { }
        public void TesteException(double valor) {
            if (valor == 0) {
                throw new ExceptionOrderInvalid("Ordem de compra sem valor!\nVolte para a Loja Virtual e selecione os produtos disponíveis.");
            }
        }

        public Order(Product[] Items)
        {
            
        }
    }
}
