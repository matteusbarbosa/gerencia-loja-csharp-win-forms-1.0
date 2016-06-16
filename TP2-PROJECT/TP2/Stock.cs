using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 	Autor: Matteus Barbosa dos Santos
	Instituição: PUC Minas - Barreiro
	Contato: contato@desenvolvedormatteus.com.br
	Website: https://www.desenvolvedormatteus.com.br
	Última atualização: Junho de 2016
	Licença: Livre para uso comercial
*/

namespace TP2
{
   public class Stock {
        public Dictionary<Product, int> Items { get; set; }
        public Shop Shop { get; set; }
        public Product First { get; set; }
        public Product Last { get; set; }
        public int ITENS_AMOUNT = 0;
    }
}
