namespace TP2_Heritage
{
    public class Zombie : Enemy
    {
        protected override void Start()
        {
            base.Start();

            health = 100;
            damage = 10;
            speed = 2f;
            detectionRange = 10f;
        }
    }
}