using UnityEngine;

namespace TP3_Polymorphisme
{
    public class WeaponManager : MonoBehaviour
    {
        public GameObject sword;
        public GameObject bow;
        public GameObject wand;

        private IWeapon currentWeapon;

        private void Start()
        {
            currentWeapon = new Sword();
        }

        public void Attack()
        {
            currentWeapon.Attaquer(transform);
        }

        public void SwitchWeapon(string weaponName)
        {
            switch (weaponName)
            {
                case "sword":
                    currentWeapon = new Sword();
                    break;

                case "bow":
                    currentWeapon = new Bow();
                    break;

                case "wand":
                    currentWeapon = new Wand();
                    break;

                case "axe":
                    currentWeapon = new Axe();
                    break;
            }

            sword.SetActive(weaponName == "sword");
            bow.SetActive(weaponName == "bow");
            wand.SetActive(weaponName == "wand");

            Debug.Log("Switched to " + weaponName);
        }
    }
}