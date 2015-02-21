using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTextGame
{
    public abstract class Player
    {
        public int exp;

        public List<Item> Inventory = new List<Item>();

        public string Name { get; set; }
        public abstract string ClassString { get; }

        public Location CurrentLocation { get; set; }

        public int Level = 1;

        public Weapon EquippedWeapon { get; set; }

        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }
    }
}