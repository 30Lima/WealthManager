namespace WealthManagerLib
{
    public abstract class Transacao
    {
        // Aqui, criei as propriedades financeiras do projeto.
        public string Descricao { get; private set; }
        public decimal Valor { get; private protected set; }
        public DateTime Data { get; private set; }

        protected Transacao(string descricao, decimal valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

        public abstract void ExibirDetalhes();
    }
}
