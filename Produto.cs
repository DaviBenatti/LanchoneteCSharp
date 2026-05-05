using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCSharp
{
    public abstract class Produto
    {
        public string nome {get;set;}
        public decimal precoBase {get;set;}

        public abstract void calcularPrecoFinal();

        public void exibirResumo()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço final: ");
        }
    }
}