using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCSharp.Models
{
    public class Sobremesa : Produto
    {
        public Sobremesa(string nomeProduto, decimal precoBaseProduto) : base(nomeProduto, precoBaseProduto)
        {}

        public decimal aplicarDesconto()
        {
            return precoBase * 0.10m;
        }

        public override decimal calcularPrecoFinal()
        {
            return precoBase - aplicarDesconto();
        }

        public override void exibirResumoProduto()
        {
            Console.WriteLine($"Tipo: Sobremesa");
            base.exibirResumoProduto();
            Console.WriteLine($"Desconto: {aplicarDesconto():f2}");
            Console.WriteLine();
        }
    }
}