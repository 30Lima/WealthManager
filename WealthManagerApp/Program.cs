using System;
using WealthManagerLib;

class Program
{
    static void Main()
    {
        GerenciadorFinanceiro gerenciador = new GerenciadorFinanceiro();

        //Abaixo, estou simulando alguns dados para o projeto
        gerenciador.AdicionarTransacao(new Receita("Salário", 3000, DateTime.Now));
        gerenciador.AdicionarTransacao(new Despesa("Aluguel", 1200, DateTime.Now));
        gerenciador.AdicionarTransacao(new Despesa("Supermercado", 500, DateTime.Now));

        // Exibindo as transações no terminal 
        gerenciador.ExibirTransacoes();
    }
}
