using GameTOP.Lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador("Ronaldo"), new Jogador("Zagueiro"), new Jogador("Robinho"));
            jogo.IniciarJogo();
        }
    }
}
