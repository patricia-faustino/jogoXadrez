using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        //Classe para auxiliar a pensar no console no contexto do xadrez
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toposicao()
        {
            return new Posicao (8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return ""+ coluna+ linha;
        }
    }
}
