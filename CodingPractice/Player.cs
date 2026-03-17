using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }

        public Player(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
}
