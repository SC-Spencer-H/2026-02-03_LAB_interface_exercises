
using App.Classes;

internal class Program
{
    static void Main()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        enemy.Move();
        player.Move();
    }
}