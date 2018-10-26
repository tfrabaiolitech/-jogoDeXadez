using System;
using xadrez;
using tabuleiro;

namespace jogoDeXadez_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos.toPosicao());

        }

    }
}

