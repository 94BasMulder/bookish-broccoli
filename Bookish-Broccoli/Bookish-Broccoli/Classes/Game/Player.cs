using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Bookish_Broccoli.Classes.Game
{
    /// <summary>
    /// Class for holding the player stats
    /// </summary>
    public class Player
    {
        //var for player color
        private char color;
        public char Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == 'W' || value == 'B')
                    color = value;
            }
        }


        //Time player has played or has left for current game
        public Timer Playtime { get; set; }
        
        //Name of the player
        public string Name { get; set; }

        /// <summary>
        /// Create new Player object
        /// </summary>
        public Player() { }
        /// <summary>
        /// Creates a new player object with preset values
        /// </summary>
        /// <param name="color">Color of player, W or B accepted</param>
        /// <param name="name">Name of the player</param>
        public Player(char color,string name) {
            this.Color = color;
            this.Name = name;
            this.Playtime = new Timer();
        }
    }
}
