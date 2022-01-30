using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosicao()//coverte a posicao de xadrez, para posicao de matriz
        {
            return new Posicao(8 - linha, coluna - 'a');
            //lembrando que linha e coluna comecam em 0.
            //se a posicao de xadrez for C7(coluna C, linha 7 [debaixo pra cima]), será em matriz igual a 1,2(linha 8-7 = 1; coluna 'C' - 'A' = 2 [3-1 = 2])

        }
        public override string ToString()
        {
            return $"{coluna}{linha}";
        }
    }
}
