using System;
using System.Collections.Generic;
using System.Text;
using App.Interfaces;

namespace App.Classes
{
    internal class Enemy : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Enemy stalks silently");
        }
    }
}
