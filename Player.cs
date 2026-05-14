using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsGame
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WinCount { get; set; }
        public int LoseCount { get; set; }
    }
}
