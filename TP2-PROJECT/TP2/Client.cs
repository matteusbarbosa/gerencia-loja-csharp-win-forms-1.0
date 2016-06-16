using System;
using System.Collections.Generic;
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

    /*Classe Cliente */
{
    public class Client : User {
        public long Number { get; set; }
        public List<Order> Orders { get; set; }

        public Client(long rnd) {
            Number = rnd;
        }
    }
}
