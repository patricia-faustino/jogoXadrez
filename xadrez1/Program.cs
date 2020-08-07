using System;
using tabuleiro;

namespace xadrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine();
                Tela.imprimirTabuleiro(tab);
        }
    }
}
