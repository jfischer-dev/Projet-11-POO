namespace TP_5
{
    public class Equipement
    {
        public Weapon equipeWeapon;
        public Armor equipeHelmet;
        public Armor equipeChest;
        public Armor equipeBoot;

        public void EquipWeapon(Weapon weapon)
        {
            equipeWeapon = weapon;
        }

        public void EquipArmor(Armor armor)
        {
            if (armor.armorType == "Helmet")
            {
                equipeHelmet = armor;
            }

            if (armor.armorType == "Chest")
            {
                equipeChest = armor;
            }

            if (armor.armorType == "Boots")
            {
                equipeBoot = armor;
            }
        }
    }
}
