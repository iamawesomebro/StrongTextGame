using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTextGame
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public Item(int id, string name, int lvl)
        {
            ID = id;
            Name = name;
            Level = lvl;
        }
    }
}
