using System;
using Objeto_Argumento.classes;

namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Air Jordan 1 Retro High OG Chicago", 1.500f);
            Produto p2 = new Produto(2, "Air Jordan 11 Concord", 415f);
            Produto p3 = new Produto(3, "Air Jordan 6 Infrared", 324f);


            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarCarrinho(p1);
            carrinho.AdicionarCarrinho(p2);
            carrinho.AdicionarCarrinho(p3);

            carrinho.MostrarProduto();
        }
    }
}
