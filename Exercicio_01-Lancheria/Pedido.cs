using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01_Lancheria
{
    public class Pedido
    {
        public bool codigoValido, quantidadeValida;
        public double valorAtual = 0.0;
        public int codigo, quantidade;
        public static double valorTotal = 0.0;
        public static List<Produto> listaPedido = new List<Produto>();
        public bool GerarPedido(List<Produto> listaProdutos, bool pedidoFinalizado)
        {
            Console.WriteLine("\nUtilizando como referência o cardápio acima, informe:");
            do
            {
                Console.Write("\nCódigo do item desejado: ");
                string tentativaCodigo = Console.ReadLine();
                codigoValido = int.TryParse(tentativaCodigo, out codigo);
                if (codigo == 999)
                {
                    return true;
                }
                foreach (Produto produto in listaProdutos)
                {
                    if (produto.Codigo == codigo)
                    {
                        valorAtual = produto.ValorUnitario;
                        listaPedido.Add(produto);
                        codigoValido = true;
                        break;
                    }
                    codigoValido = false;
                }
                if (!codigoValido)
                {
                    Console.WriteLine("Por favor, informe um código válido!");
                }
            } while (!codigoValido);
            do
            {
                Console.Write("    Quantidade desejada: ");
                string tentativaQuantidade = Console.ReadLine();
                quantidadeValida = int.TryParse(tentativaQuantidade, out quantidade);
                if (quantidade < 1 || !quantidadeValida)
                {
                    Console.WriteLine("Por favor, informe uma quantidade válida!");
                }
            } while (quantidade < 1 || !quantidadeValida);
            valorTotal += valorAtual * quantidade;
            return false;
        }
    }
}