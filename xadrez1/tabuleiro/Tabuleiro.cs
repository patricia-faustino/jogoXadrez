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

        //Sobrecarga para receber pela matriz pela posicao indicada
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linhas, pos.colunas];
        }
        //Metodo para verificar se existe uma posicao e se ela eh valida
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos)!=null;
        }


        //Colocar peca p na posicao pos
        public void colocarPeca(Peca p, Posicao pos)
        {
            //soh pode colocar peca onde nao tem outra peca
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }
            // ir na matriz na posicao pecas e posicao coluna  e receber p
            pecas[pos.linhas, pos.colunas] = p;
            // ir na peca p e dizer que a peca p vai ter uma posicao pos
            p.posicao = pos;
        }
        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            //
            Peca aux = peca(pos);
            aux.posicao = null; // aux foi retirada
            pecas[pos.linhas, pos.colunas] = null; // posicao vazia
            return aux;

        }
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linhas < 0 || pos.linhas >= linhas || pos.colunas < 0 || pos.colunas >= colunas)
            {
                return false;
            }
            return true;
        }

        //Retornar excecao personalizada caso a posicao nao seja valida
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }


        }
    }
}
