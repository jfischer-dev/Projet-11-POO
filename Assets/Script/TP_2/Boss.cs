public class Boss : Enemy
{
    protected override void Start()
    {
        base.Start();

        health = 300;
        damage = 25;
        speed = 1.5f;
        detectionRange = 15f;
    }

    protected override void Die()
    {
        print("Le Boss est vaincu !");
        base.Die();
    }
}