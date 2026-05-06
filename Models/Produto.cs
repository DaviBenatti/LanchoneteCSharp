using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCSharp.Models
{
    public abstract class Produto
    {
        private decimal precoBaseProduto;
        public string nomeProduto { get; set; }
        public decimal precoBase
        {
            get { return precoBaseProduto; }

            set
            {
                if(value >= 0)
                    precoBaseProduto = value;
                else
                    precoBaseProduto = 0;
            }
        }
        // Construtor
        public Produto(string nome, decimal precoBase)
        {
            nomeProduto = nome;
            precoBaseProduto = precoBase;
        }

        public abstract decimal calcularPrecoFinal();

        public virtual void exibirResumoProduto()
        {
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço final: R${calcularPrecoFinal():f2}");
        }
    }
}