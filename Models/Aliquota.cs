namespace INSS
{
    public class Aliquota
    {
        public Aliquota(decimal desconto, bool valorAbsoluto)
        {
            Desconto = desconto;
            ValorAbsoluto = valorAbsoluto;
        }

        public decimal Desconto { get; }
        public bool ValorAbsoluto { get; }
    }
}