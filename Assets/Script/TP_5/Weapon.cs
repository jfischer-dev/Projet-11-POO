namespace TP_5
{
    public class Weapon : Item
    {
        public int damage;
        public float range;

        public override void UseItem(Player player)
        {
            player.Attack(damage);
        }
    }
}