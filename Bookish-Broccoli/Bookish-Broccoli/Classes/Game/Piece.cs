using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookish_Broccoli.Classes.Game;

namespace Bookish_Broccoli.Classes
{
    public class Piece
    {
        public string Location { get; set; }
        public int steps { get; set; }
        public PieceType PieceType { get; set; }
    }
}
