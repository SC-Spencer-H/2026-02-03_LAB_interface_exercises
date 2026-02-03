using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using App.Interfaces;

namespace App.Classes
{
    internal class Player : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Player moves forward");
        }
    }
}
