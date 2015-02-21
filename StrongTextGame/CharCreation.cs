using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTextGame
{
    class CharCreation
    {
        Player _player;

        public CharCreation(Player player)
        {
            _player = player;
            Console.WriteLine("Please enter a name /n Name: ");
            _player.Name = Console.ReadLine();
            Console.WriteLine("Please enter a class (Warrior, Mage) /n Class: ");
            getCharClass(Console.ReadLine());
        }

        public void getCharClass(string input) //I did this when it was a WPF form, probably an easier, cleaner, way of doing it.
        {
            switch (input)
            {
                case "Warrior":
                    _player = new Warrior();
                    break;
                case "Mage":
                    _player = new Mage();
                    break;
            }
        }

    }
}
