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
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //Sobrecarga para receber pela matriz pela posicao indicada
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        //Metodo para verificar se existe uma posicao e se ela eh valida
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
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
            pecas[pos.linha, pos.coluna] = p;
            // ir na peca p e dizer que a peca p vai ter uma posicao pos
            p.posicao = pos;
        }
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            //
            Peca aux = peca(pos);
            aux.posicao = null; // aux foi retirada
            pecas[pos.linha, pos.coluna] = null; // posicao vazia
            return aux;

        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
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

