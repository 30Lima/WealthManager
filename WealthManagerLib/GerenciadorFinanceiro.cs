using System.Collections.Generic;  // Importa a biblioteca para usar List<T>

namespace WealthManagerLib
{
    public class GerenciadorFinanceiro
    {
        private List<Transacao> transacoes = new List<Transacao>();  // Lista para armazenar transações

        // Método para adicionar uma transação (receita ou despesa)
        public void AdicionarTransacao(Transacao transacao)
        {
            transacoes.Add(transacao);
        }

        // Método para exibir todas as transações cadastradas
        public void ExibirTransacoes()
        {
            Console.WriteLine("\n=== Histórico de Transações ===");
            foreach (var transacao in transacoes)  // Percorre a lista de transações
            {
                transacao.ExibirDetalhes();  // Chama o método ExibirDetalhes() de cada transação
            }
            Console.WriteLine("==============================\n");
        }
    }
}
