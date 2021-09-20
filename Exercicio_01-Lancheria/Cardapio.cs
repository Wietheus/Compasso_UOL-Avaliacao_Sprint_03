using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01_Lancheria
{
    public class Cardapio
    {
        public void ExibirCardapio()
        {
            Console.Clear();
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("|              Lancheria do Vivente              |");
            Console.WriteLine("|--------+-----------------+---------------------|");
            Console.WriteLine("| Código | Produto         | Preço Unitário (R$) |");
            Console.WriteLine("|--------|-----------------|---------------------|");
            Console.WriteLine("| 100    | Cachorro Quente |                5,70 |");
            Console.WriteLine("| 101    | Xis Completo    |               18,30 |");
            Console.WriteLine("| 102    | Xis Salada      |               16,50 |");
            Console.WriteLine("| 103    | Hambúrguer      |               22,40 |");
            Console.WriteLine("| 104    | Coca-Cola 2L    |               10,00 |");
            Console.WriteLine("| 105    | Refrigerante    |                1,00 |");
            Console.WriteLine("| 999    | Encerrar Pedido | ------------------- |");
            Console.WriteLine("+--------+-----------------+---------------------+");
        }
        public List<Produto> RegistrarProdutos()
        {
            Produto cachorroQuente = new Produto(100, "Cachorro Quente", 5.7);
            Produto xisCompleto = new Produto(101, "Xis Completo", 18.3);
            Produto xisSalada = new Produto(102, "Xis Salada", 16.5);
            Produto hamburguer = new Produto(103, "Hambúrguer", 22.4);
            Produto cocaCola = new Produto(104, "Coca-Cola 2L", 10.0);
            Produto refrigerante = new Produto(105, "Refrigerante", 1.0);
            List<Produto> listaProdutos = new List<Produto> { cachorroQuente, xisCompleto, xisSalada, hamburguer, cocaCola, refrigerante };
            return listaProdutos;
        }
    }
}