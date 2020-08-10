namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null; //quando voce cria uma peca a posicao dela é nula
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        //verificacao de movimentos possíveis
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentoPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Melhorar legibilidade em relãção a movimentos possíveis para uma determinada posicao
        public bool podeMoverPara(Posicao pos)
        {
            return movimentoPossiveis()[pos.linha, pos.coluna];
        }
        //indica para onde a peca pode mover
        public abstract bool[,] movimentoPossiveis();
    }
}

