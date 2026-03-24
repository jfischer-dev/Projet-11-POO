namespace TP_5
{
    public class Potion : Item
    {
        public int healthRestored;
        public float duration;
        public override void UseItem(Player player)
        {
            player.RestoreHealth(healthRestored);
        }
    }
}