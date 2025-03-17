namespace WealthManagerLib
{
    public abstract class Transacao
    {
        // Aqui, criei as propriedades financeiras do projeto.
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        protected Transacao(string descricao, decimal valor, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

        public abstract void ExibirDetalhes();
    }
}
