﻿using tabuleiro;

namespace xadrez {
    class Torre : Peca {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {

        }

        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {

            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Verifica uma casa acima da posição atual da Torre
            pos.definirValores(posicao.linha - 1, posicao.coluna);

            while(tab.posicaoValida(pos) && podeMover(pos)) {

                mat[pos.linha, pos.coluna] = true;

                if(tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }

                pos.linha = pos.linha - 1;
            }

            //Verifica uma casa abaixo da posição atual da Torre
            pos.definirValores(posicao.linha + 1, posicao.coluna);

            while (tab.posicaoValida(pos) && podeMover(pos)) {

                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }

                pos.linha = pos.linha + 1;
            }

            //Verifica casa a direita da posição atual da Torre
            pos.definirValores(posicao.linha, posicao.coluna + 1);

            while (tab.posicaoValida(pos) && podeMover(pos)) {

                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }

                pos.coluna = pos.coluna + 1;
            }

            //Verifica casa a esquerda da posição atual da Torre
            pos.definirValores(posicao.linha, posicao.coluna - 1);

            while (tab.posicaoValida(pos) && podeMover(pos)) {

                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }

                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }

    }
}
