using System;
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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca (Peca p, Posicao pos){
            if(existePeca(pos)){ // Já testa se a posição é válida ou não
                throw new TabuleiroException("Já existe uma peça nesta posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // Testa se existe uma peça em uma dada posição

        public bool existePeca(Posicao pos){
            validarPosicao(pos);
            if (peca(pos) != null){
                return true;
            }
                else{
                    return false;
                }
        }

        // método que testa se a posição é valida
        public bool posicaoValida(Posicao pos){
            if(pos.linha <0 || pos.linha >linhas || pos.coluna <0 || pos.coluna > colunas){
                return false;
            }
            return true;
        }

         // Se a posição não for válida ele lança uma exceção
        public void validarPosicao (Posicao pos){
            if(!posicaoValida(pos)){
                throw new TabuleiroException("Posição inválida");
            }
        }

    }
}
