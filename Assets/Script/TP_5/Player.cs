namespace TP_5
{
    public class Player
    {
        public string name;
        public int health;
        public int maxHealth;

        public Inventory inventory = new Inventory();

        public Equipement Equipement = new Equipement();

        public void Attack(int damage)
        {
            System.Console.WriteLine($"{name} attaque pour {damage} points de dégâts!");
        }

        public void RestoreHealth(int amount)
        {
            health = System.Math.Min(health + amount, maxHealth);
            System.Console.WriteLine($"{name} restaure {amount} points de vie!");
        }

        public void UseItem(Item item)
        {
            item.UseItem(this);
        }
    }
}