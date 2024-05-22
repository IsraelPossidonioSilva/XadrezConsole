using System;
using tabuleiro;
using xadrez;


namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {
            try { 
             
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");

                    //transforma em posição de matriz
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino: ");

                    //transforma em posição de matriz
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    // chamando metodo que excuta o movimento
                    partida.executaMovimento(origem, destino);
                }              
                
            }
            catch (TabuleiroException e){

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}