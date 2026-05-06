using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCSharp.Models
{
    public class Lanche : Produto
    {
        private decimal taxaDeEmbalagem = 2m;
        public Lanche(string nomeProduto, decimal precoBaseProduto) : base(nomeProduto, precoBaseProduto)
        {}
        public override decimal calcularPrecoFinal()
        {
            return precoBase + taxaDeEmbalagem;
        }

        public override void exibirResumoProduto()
        {
            Console.WriteLine($"Tipo: Lanche");
            base.exibirResumoProduto();
            Console.WriteLine($"");     
        }
    }
}