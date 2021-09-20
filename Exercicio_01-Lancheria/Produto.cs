using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01_Lancheria
{
    public class Produto
    {
        public double ValorUnitario { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Produto(int codigo, string descricao, double valorUnitario)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.ValorUnitario = valorUnitario;
        }
    }
}