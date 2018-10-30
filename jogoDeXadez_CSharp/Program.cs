using System;
using xadrez;
using tabuleiro;
using jogoDeXadez_CSharp;

namespace jogoDeXadez_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirtabuleiro(partida.tab);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");

                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

               
            }
            catch (TabuleiroException e){
                Console.WriteLine(e.Message);
            } 
        }
    }
}
