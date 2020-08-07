using System;
using tabuleiro;

namespace xadrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine(tab);
            Posicao p = new Posicao(3, 4);
            Console.WriteLine("Posição: "+p);
            Console.WriteLine("Hello World!");
        }
    }
}
