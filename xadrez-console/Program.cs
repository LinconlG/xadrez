using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Partida p = new Partida();
                while (!p.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(p.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicao().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicao().toPosicao();

                   p.executarMovimento(origem, destino);//bug da 'posicao' resolvido
                }
                
                

               
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
