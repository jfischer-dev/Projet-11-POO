namespace TP_5
{
    public class Armor : Item
    {
        public int defense;
        public string armorType; // "Helmet", "Chest", "Boots", etc.

        public override void UseItem(Player player)
        {
            player.Equipement.EquipArmor(this);
        }
    }
}