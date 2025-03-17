using System.Collections.Generic;

namespace WealthManagerLib
{
    public class GerenciadorFinanceiro
    {
        private List<Transacao> transacoes = new List<Transacao>();


        public void AdicionarTransacao(Transacao transacao)
        {
            transacoes.Add(transacao);
        }


        public void ExibirTransacoes()
        {
            Console.WriteLine("\n=== Histórico de Transações ===");
            foreach (var transacao in transacoes)
            {
                transacao.ExibirDetalhes();
            }
            Console.WriteLine("==============================\n");
        }
    }
}
