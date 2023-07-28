using tabuleiro;
using xadrez_console2;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    Tela.imprimirTabuleiro(partida.tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();