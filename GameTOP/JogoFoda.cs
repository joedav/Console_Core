using GameTOP.Interface;
using GameTOP.Lib;
using System;

namespace GameTOP
{
    class JogoFoda
    {
        private readonly Jogador _jogador;
        private readonly Jogador _jogador2;
        private readonly Jogador _jogador3;
        public JogoFoda(Jogador jogador, Jogador jogador2, Jogador jogador3)
        {
            _jogador = jogador;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
        }
        public void IniciarJogo()
        {
            Console.Write(_jogador.Correr());
            Console.Write(_jogador.Driblar(_jogador2));
            Console.Write(_jogador.Passar(_jogador3));
            Console.Write(_jogador3.Chutar());
        }
    }
}
