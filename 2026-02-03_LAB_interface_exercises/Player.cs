using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using App.Interfaces;

namespace App.Classes
{
    internal class Player : Character, IMovable, IAttack, IInteractable
    {
        public override string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves forward");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} swings weapon");
        }

        public void Interact()
        {
            Console.WriteLine($"{Name} is ready to fight");
        }
    }
}
