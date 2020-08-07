using System;
using tabuleiro;
using xadrez;

namespace xadrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toposicao());
        }
    }
}
