using GameTOP.Interface;
using System;

namespace GameTOP.Lib
{
    public class Jogador : IJogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }
        public string Correr()
        {
            return $"{_Nome} está correndo!\n";
        }
        public string Chutar()
        {
            return $"{_Nome} chutou!\n";
        }
        
        public string Passar(Jogador jogador)
        {
            return $"{_Nome} passou a bola para {jogador._Nome}\n";
        }
        public string Driblar(Jogador jogador)
        {
            return $"{_Nome} driblou o {jogador._Nome}\n";
        }

        public string Passar()
        {
            throw new NotImplementedException();
        }

        public string Driblar()
        {
            throw new NotImplementedException();
        }
    }
}
