﻿using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole {
    class Tela {
        
        public static void imprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i< tab.linhas; i++) {

                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.colunas; j++) {

                    if(tab.peca(i,j) == null) {

                        Console.Write("- ");
                    }else {

                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        // Vai ler o que usuário digitar no teclado
        public static PosicaoXadrez lerPosicaoXadrez() {

            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }




        public static void imprimirPeca(Peca peca) { 
            if(peca.cor == Cor.Branca) {
                Console.Write(peca);
            }
            else {

                //trocando a cor da peça preta para Amarela para diferenciar
                ConsoleColor aux = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(peca);
                Console.ForegroundColor= aux;
            }
        }

    }
}
