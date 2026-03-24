namespace TP_5
{
    public abstract class Item
    {
        public string name;
        public string description;
        public float weight;
        public int value;

        public abstract void UseItem(Player player);
    }
}
