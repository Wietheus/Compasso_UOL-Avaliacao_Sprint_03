using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01_Lancheria
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool mesaValida, pedidoFinalizado = false;
            int mesa;
            var cardapio = new Cardapio();
            var pedido = new Pedido();
            Console.WriteLine("Opa! Te aprochega na Lancheria do Vivente!\nAs mesas 1, 2, 3 e 4 estão disponíveis.");
            do
            {
                Console.Write("\nQual mesa gostaria de usar? ");
                string tentativaMesa = Console.ReadLine();
                mesaValida = int.TryParse(tentativaMesa, out mesa);
                if (mesa != 1 && mesa != 2 && mesa != 3 && mesa != 4)
                {
                    Console.WriteLine("Por favor, informe uma mesa válida!");
                }
            } while ((mesa != 1 && mesa != 2 && mesa != 3 && mesa != 4) || !mesaValida);
            Console.Write($"\nMesa {mesa} selecionada.\nPressione alguma tecla para efetuar o pedido...");
            Console.ReadKey();
            var listaProdutos = cardapio.RegistrarProdutos();
            do
            {
                cardapio.ExibirCardapio();
                pedidoFinalizado = pedido.GerarPedido(listaProdutos, pedidoFinalizado);
            } while (!pedidoFinalizado);
            Console.Clear();
            Console.WriteLine($"Pedido na mesa {mesa} finalizado.\n");
            int i = 1;
            foreach (Produto produto in Pedido.listaPedido)
            {
                if (i < 10)
                {
                    Console.Write("0");
                }
                Console.WriteLine(i + " - " + produto.Descricao);
                i++;
            }
            Console.WriteLine("\nValor total: R$ " + Pedido.valorTotal.ToString("f2"));

            //Console.WriteLine("\nEm JSON:");

            Console.Write("\nPressione alguma tecla para encerrar...");
            Console.ReadKey();
            //Após finalizar pedido, imprimir a lista de itens do pedido em formato JSON (utilize a classe JavaScriptSerializer()).
        }
    }
}