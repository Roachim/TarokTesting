using System;
using System.Collections.Generic;
using System.Text;

namespace TarokScoreTesting
{
    public class Player
    {
        //has points
        public int Cup { get; set; }
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}
