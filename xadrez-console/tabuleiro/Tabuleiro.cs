using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; //aqui determina a matriz de peças, a matriz de peças tem q ter o mesmo tamanho que o tabuleiro, por isso é instanciado aqui dentro 
        }       //essa matriz de peças é o que é usada como lógica para exibir na tela (consultar "Tela.cs")
        public Peca peca(int linha, int coluna)//retorna a peça que está na posição indicada
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("ja existe uma peça nesta posição!");
            }

            pecas[pos.linha, pos.coluna] = p; //insere a peça na matriz de peças do tabuleiro
            p.posicao = pos; //a peça recebe a posição


        }
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null; //tira a posicao da peca
            pecas[pos.linha, pos.coluna] = null; //tira a peca do tabuleiro, deixando as posicoes no tab nulas
            return aux;

        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
                throw new TabuleiroException("Posicao invalida!");
        }
    }
}
