﻿using System;
namespace tabuleiro
{
     class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // Matriz peça que apenas o tabuleiro tem acesso.

        public Tabuleiro(int linhas, int colunas)

        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linhas, int colunas) // método publico para acessar a Peça
        {
            return pecas[linhas, colunas];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}