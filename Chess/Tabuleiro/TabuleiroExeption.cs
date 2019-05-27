using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.tabuleiro
{
    class TabuleiroExeption : Exception
    {
        public TabuleiroExeption(string msg) : base(msg) { }
    }
}
