namespace ControleEstoque;

public class Classes
{
    public class Item
    {
        public string NumeroLote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public DateTime DataVencimento { get; set; }
    }

    public class VendaItem
    {
        public Item Item { get; set; }
        public int Quantidade { get; set; }
    }

    public class Venda
    {
        public int NumeroPedido { get; set; }
        public List<VendaItem> Itens { get; set; } = new List<VendaItem>();

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var item in Itens)
            {
                total += item.Item.QuantidadeEstoque;
            }

            return total;
        }
    }
}