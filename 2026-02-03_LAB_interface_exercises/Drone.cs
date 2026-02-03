using System;
using System.Collections.Generic;
using System.Text;
using App.Interfaces;

namespace App.Classes
{
    internal class Drone : IFlyable, IShootable, IInteractable
    {
        public void Fly()
        {
            Console.WriteLine("Drone flies upward");
        }

        public void Shoot()
        {
            Console.WriteLine("Drone shoots lasers");
        }

        public void Interact()
        {
            Console.WriteLine("Drone beeps sarcastically");
        }
    }
}
