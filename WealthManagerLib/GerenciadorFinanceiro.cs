using System.Collections.Generic;

namespace WealthManagerLib
{
    public class GerenciadorFinanceiro
    {
        private readonly List<Transacao> transacoes = new();  // Lista privada e imutável externamente

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
