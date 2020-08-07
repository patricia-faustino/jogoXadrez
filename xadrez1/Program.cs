using System;
using tabuleiro;
using xadrez;

namespace xadrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                   
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao(); //ler posicao e transforma-la em posicao de matriz
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }


                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
