using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCSharp.Models
{
    public class Bebida : Produto
    {
        public Bebida(string nomeProduto, decimal precoBaseProduto) : base(nomeProduto, precoBaseProduto)
        {}

        public override decimal calcularPrecoFinal()
        {
            return precoBase;
        }

        public override void exibirResumoProduto()
        {
            Console.WriteLine($"Tipo: Bebida");
            base.exibirResumoProduto();
            Console.WriteLine();
        }
    }
}