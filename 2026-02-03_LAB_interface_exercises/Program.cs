
using App.Classes;
using App.Interfaces;

internal class Program
{
    static void Main()
    {
        List<IInteractable> Interactables = new List<IInteractable> 
        { 
            new Player("Hero"), 
            new Enemy("Thrall"), 
            new Drone() 
        };

        for (int i = 0; i < Interactables.Count; i++)
        {
            Interactables[i].Interact();
        }
    }
}