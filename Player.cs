using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Player
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private Image chessBoxMark;
        public Image ChessBoxMark
        {   
            get => chessBoxMark;
            set => chessBoxMark = value;
        }

        public Player(string name, Image chessBox)
        {
            this.Name = name;
            this.chessBoxMark = chessBox;
        }
    }
}
