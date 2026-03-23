namespace TP2_Heritage
{
    public class Skeleton : Enemy
    {
        protected override void Start()
        {
            base.Start();

            health = 80;
            damage = 15;
            speed = 3f;
            detectionRange = 12f;
        }
    }
}