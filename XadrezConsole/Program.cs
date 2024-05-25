using System;
using tabuleiro;
using xadrez;


namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {
            try {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    try {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando Peça: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();//transforma em posição de matriz
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();//transforma em posição de matriz
                        partida.validarPosicaoDestino(origem, destino);

                        partida.realizaJogada(origem, destino);// chamando metodo que excuta o movimento
                    }
                    catch (TabuleiroException e) {

                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }

            catch (TabuleiroException e){

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}