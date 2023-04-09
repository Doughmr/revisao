namespace revisao.Models
{
    public class Movimentacao
    {
        public long Id { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }

        public Decimal ValorDevido { get; set; }
        public Decimal ValorPago { get; set; }

        public int TotalParcelas { get; set; }
        public int NumeroParcelas { get; set; }

    }

}

