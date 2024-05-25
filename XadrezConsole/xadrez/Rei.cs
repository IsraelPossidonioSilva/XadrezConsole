using tabuleiro;

namespace xadrez {
    class Rei : Peca{

        public Rei(Tabuleiro tab, Cor cor): base(tab, cor) { 
                
        }

        public override string ToString() {
            return "R";
        }
        private bool podeMover(Posicao pos) {

            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; 
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Verifica uma casa acima da posição atual do rei
            pos.definirValores(posicao.linha - 1, posicao.coluna);

            if(tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa na diagonal superior (direita) nordeste da posição atual do rei
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa a direita da posição atual do rei
            pos.definirValores(posicao.linha, posicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa na sudeste da posição atual do rei
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa abaixo da posição atual do rei
            pos.definirValores(posicao.linha + 1, posicao.coluna);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa na diagonal inferior(esquerda) sudoeste da posição atual do rei
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa da esquerda da posição atual do rei
            pos.definirValores(posicao.linha, posicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verifica casa na diagonal superior (esquerda) noroesta da posição atual do rei
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

    }
}
