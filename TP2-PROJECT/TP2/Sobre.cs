using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class FrmSobre : Form {
        public FrmSobre() {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e) {
            label5.Text = "Trabalho Prático apresentado ao Curso de Sistmas de Informação da\nPontifícia Universidade Católica de Minas Gerais, como requisito parcial\npara obtenção do título de Bacharel em Sistemas de Informação.";
        }
    }
}

/* Gerência de loja 1.0

O Problema
Uma empresa possui tanto lojas físicas de comércio de produtos eletrônicos em várias cidades do Brasil quanto uma loja virtual de comércio eletrônico. 
Os sistemas de estoque das várias lojas físicas e da loja virtual são interligados de modo que mercadorias adquiridas via Internet podem ser retiradas 
nas lojas físicas se o cliente assim preferir, sem custo de entrega. Nesse caso, ele deve escolher em qual loja vai retirar. Logicamente, ele pode preferir 
entrega via SEDEX, com pagamento de determinada taxa. Suponha que exista um número de produtos em comercialização, cada qual com certa quantidade para vendas
virtuais e para vendas “físicas”. Suponha que possa existir alguns produtos em uma loja, mas não em outras, inclusive na virtual.

Em seu código, considere que os dados de cada produto estão separados por “tabs” (‘\t’), para facilitar, e que os identificadores das lojas e os nomes dos produtos (PRODUTO1, PRODUTO2, etc) são strings únicas (isto é, não há lojas com mesmos nomes nem produtos com mesmos nomes, dentro do mesmo estoque). Considere, também, que o número de lojas da rede, que a quantidade de cada produto e que o número de produtos no estoque de cada loja são números inteiros, sendo que estes últimos podem variar de loja para loja (x, k, n, no exemplo). Além disso, os preços são números reais.

Os dados deste arquivo devem ser carregados em um vetor no qual cada elemento é uma referência para uma Loja. Cada loja tem uma referência para uma árvore binária de pesquisa que deve armazenar o estoque de uma loja em particular. Ao pesquisar por um produto, a busca é feita no estoque da loja em questão. Caso não seja encontrado, o produto deve ser procurado nas demais lojas. Se for encontrado, o cliente deve ser informado para que ele decida se quer retirar o mesmo na loja ou receber pelo SEDEX. 

Uma compra

Para executar uma compra deve-se supor que apenas a loja virtual é utilizada. O usuário deve selecionar um item de compra de um “menu”. Em seguida, é exibida uma lista de produtos na qual o usuário escolhe um deles. O produto é buscado em todas as lojas, começando pela loja virtual. É exibida uma lista de lojas nas quais o produto foi encontrado e o usuário deve escolher uma loja para retirada ou o envio pelo correio, bem como a forma de pagamento.


Relatório de vendas – Crédito extra

Ao ser selecionada esta opção, deve ser exibido um relatório com todos os produtos vendidos e o faturamento total naquela sessão.


Relatório de estoque local

Exibe o estoque de uma loja especificada na entrada.


Relatório de estoque geral

Exibe todos os estoques de todas as lojas.


Tipos a serem implementados

Pelo menos os seguintes tipos devem ser implementados para representar objetos conceituais:

Loja		(interface ou classe abstrata)
Loja virtual
Loja física
Estoque
Relatório
Produto		(interface ou classe abstrata)
Cliente (usuário)
Compra (ou transação ou venda)

Além disso, devem ser implementados tipos para representar objetos necessários a implementação:

Interface do sistema
Módulo de leitura do arquivo

Obrigatoriamente, deve ser feito tratamento de exceções nos módulos que fazem leitura de dados de arquivo e em todos os métodos nos quais possam ocorrer exceções por uso de referência nula (null).
*/