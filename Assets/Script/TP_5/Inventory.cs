using System.Collections.Generic;

namespace TP_5
{
    public class Inventory
    {
        public List<Item> items = new List<Item>(); // Taille fixe d'inventaire
        public int itemCount = 0;

        public void AddItem(Item item)
        {
            items.Add(item);
            itemCount++;
        }

        public void RemoveItem(Item item)
        {
            if (items.Remove(item))
            {
                itemCount--;
            }
        }

        public float GetTotalWeight()
        {
            float totalWeight = 0;

            foreach (var item in items)
            {
                totalWeight += item.weight;
            }

            return totalWeight;
        }
    }
}