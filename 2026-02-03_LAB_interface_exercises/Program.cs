
using App.Classes;

internal class Program
{
    static void Main()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        player.Move();
        enemy.Move();
    }
}