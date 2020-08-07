using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //permicao para programador acessar peca individual já que a matriz peca é private
        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        //Colocar peca p na posicao pos
        public void colocarPeca(Peca p, Posicao pos)
        {
            // ir na matriz na posicao pecas e posicao coluna  e receber p
            pecas[pos.linhas, pos.colunas] = p;
            // ir na peca p e dizer que a peca p vai ter uma posicao pos
            p.posicao = pos;
        }
    }
}
