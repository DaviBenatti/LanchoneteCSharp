using LanchoneteCSharp.Models;

namespace LanchoneteCSharp;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Salada", 26m));
        pedido.Add(new Bebida("Pepsi Black", 6m));
        pedido.Add(new Sobremesa("Pudim", 12m));

        Console.WriteLine($"--- Resumo Pedido ---");

        decimal total = 0;

        foreach(Produto produto in pedido)
        {
            produto.exibirResumoProduto();
            total += produto.calcularPrecoFinal();
        }

        Console.WriteLine($"Total do pedido: R${total:f2}");
    }
}
