using System;
using System.Collections.Generic;
using System.Text;
using App.Interfaces;

namespace App.Classes
{
    internal class Enemy : Character, IMovable, IAttack
    {
        public override string Name { get; set; }

        public Enemy(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} stalks silently");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} swipes claws");
        }
    }
}
