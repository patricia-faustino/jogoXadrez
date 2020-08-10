using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab,cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentoPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas]; // matriz tem o mesmo numero de linhas e colunas do tabuleiro
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            //enquanto estiver casa livre e peca adversaria pode mover
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //parar while quando tiver peca adversaria
                //se a posicao for diferente de nulo e a cor da peca for diferente da adversaria
                //forcar parada
                if(tab.peca(pos)!= null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //vai para proxima posicao acima
                pos.linha = pos.linha - 1;
            }

            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
           
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
               
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                
                pos.linha = pos.linha + 1;
            }

            //direita

            pos.definirValores(posicao.linha, posicao.coluna+1);
         
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                
                pos.coluna= pos.coluna+ 1;
            }

            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna -1);
            
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
               
                pos.coluna = pos.coluna -1;
            }


            return mat;


        }
    }
}

