using System;
using System.Collections.Generic;
using System.Text;

namespace TarokScoreTesting
{
    public class Player
    {
        //has points
        public virtual int Cup { get; set; }
        public virtual string Name { get; set; }

        #region Constructor

        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }

        #endregion


    }
}
