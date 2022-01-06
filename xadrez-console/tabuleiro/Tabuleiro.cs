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
        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p; //insere a peça na matriz de peças do tabuleiro
            p.posicao = pos; //a peça recebe a posição
        }
    }
}
