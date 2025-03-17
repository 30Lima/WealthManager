namespace WealthManagerLib
{
    public class Receita : Transacao  // Receita herda de Transacao
    {
        public Receita(string descricao, decimal valor, DateTime data)
            : base(descricao, valor, data) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[+] Receita: {Descricao} - Valor: R${Valor:F2} - Data: {Data.ToShortDateString()}");
        }
    }

    public class Despesa : Transacao
    {
        public Despesa(string descricao, decimal valor, DateTime data)
            : base(descricao, valor, data) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[-] Despesa: {Descricao} - Valor: R${Valor:F2} - Data: {Data.ToShortDateString()}");
        }
    }
}
