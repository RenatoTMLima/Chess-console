using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Tabuleiro
{
    class Peca
    {
        public Posicao Pos { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        
        public Peca(Posicao pos, Cor cor, Tabuleiro tab)
        {
            Pos = pos;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }
    }
}
