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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 9));
               tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 6));

                Tela.imprimirtabuleiro(tab);
            }
            catch (TabuleiroException e){
                Console.WriteLine(e.Message);
            } 
        }
    }
}
