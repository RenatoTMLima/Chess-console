using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        
        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.cor = cor;
            Tab = tab;
            qtdMovimentos = 0;
        }

        public void incrementarQtdMov()
        {
            qtdMovimentos++;
        }
    }
}
