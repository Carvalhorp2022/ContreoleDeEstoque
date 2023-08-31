using System;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variáveis de controle
            int quantidadeEstoque = 0;
            int quantidadeVendida = 0;
            decimal valorUnitario = 10.0m;
            decimal valorTotal = 0.0m;
            
            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Entrada de estoque");
                Console.WriteLine("2. Registrar venda");
                Console.WriteLine("3. Forma de pagamento");
                Console.WriteLine("4. Sair");

                // Leitura da opção selecionada
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe a quantidade de produtos a serem adicionados no estoque:");
                        int quantidadeEntrada = Convert.ToInt32(Console.ReadLine());
                        quantidadeEstoque += quantidadeEntrada;
                        Console.WriteLine("Entrada de estoque registrada. Estoque atual: " + quantidadeEstoque);
                        break;

                    case 2:
                        Console.WriteLine("Informe a quantidade de produtos a serem vendidos:");
                        int quantidadeVenda = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeVenda <= quantidadeEstoque)
                        {
                            quantidadeEstoque -= quantidadeVenda;
                            quantidadeVendida += quantidadeVenda;
                            valorTotal += quantidadeVenda * valorUnitario;
                            Console.WriteLine("Venda registrada. Estoque atual: " + quantidadeEstoque);
                            Console.WriteLine("Quantidade vendida: " + quantidadeVendida);
                            Console.WriteLine("Valor total: R$ " + valorTotal);
                        }
                        else
                        {
                            Console.WriteLine("Quantidade solicitada maior do que o estoque atual.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Selecione a forma de pagamento:");
                        Console.WriteLine("1. Dinheiro");
                        Console.WriteLine("2. Cartão");
                        int formaPagamento = Convert.ToInt32(Console.ReadLine());
                        if (formaPagamento == 1)
                        {
                            Console.WriteLine("Pagamento em dinheiro selecionado. Valor total: R$ " + valorTotal);
                        }
                        else if (formaPagamento == 2)
                        {
                            Console.WriteLine("Pagamento em cartão selecionado. Valor total: R$ " + valorTotal);
                        }
                        else
                        {
                            Console.WriteLine("Forma de pagamento inválida.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Saindo do programa...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
    