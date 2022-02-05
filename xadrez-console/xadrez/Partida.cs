using System;
using tabuleiro;

namespace xadrez
{
    class Partida
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public Partida()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas(tab);
            terminada = false;
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);//retorna a peca que tava na origem para 'p'
            p.incrementarMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);//coloca 'p' na posicao destino
        }

        private void colocarPecas(Tabuleiro tab)
        {
            char aux = 'a';

            for (int i = 0; i <= 7; i++)
            {
                tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez(aux , 2).toPosicao());
                tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez(aux, 7).toPosicao());
                aux++;
            }

        }
    }
}
