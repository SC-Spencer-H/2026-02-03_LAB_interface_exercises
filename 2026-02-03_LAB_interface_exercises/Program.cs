
using App.Classes;

internal class Program
{
    static void Main()
    {
        Player player = new Player("Hero");
        Enemy enemy = new Enemy("Thrall");

        player.Move();
        enemy.Move();
        player.Attack();
        enemy.Attack();
    }
}