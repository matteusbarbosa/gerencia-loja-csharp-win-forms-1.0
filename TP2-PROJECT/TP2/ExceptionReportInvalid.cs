﻿using System;
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
{
    class ExceptionReportInvalid : Exception
    {
        public ExceptionReportInvalid() : base() { }
        public ExceptionReportInvalid(string message) : base(message) { }
    }
}