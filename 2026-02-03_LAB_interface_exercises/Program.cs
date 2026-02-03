
using App.Classes;

internal class Program
{
    static void Main()
    {
        Player player = new Player("Hero");
        Enemy enemy = new Enemy("Thrall");
        Drone drone = new Drone();

        player.Move();
        enemy.Move();
        player.Attack();
        enemy.Attack();
        drone.Fly();
        drone.Shoot();
    }
}