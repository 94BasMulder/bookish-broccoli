﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish_Broccoli.Classes.Game
{
    public class Board
    {
        public Player CurrentPlayer { get; set; }
        public List<string> MoveList { get; set; }
    }
}
