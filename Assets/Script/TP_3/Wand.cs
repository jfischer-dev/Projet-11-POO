using UnityEngine;

namespace TP3_Polymorphisme
{
    public class Wand : IWeapon
    {
        public void Attaquer(Transform origine)
        {
            Debug.Log("Fire Ball");

            PlayerCharacter player = origine.GetComponent<PlayerCharacter>();

            if (player != null && player.SpendMana(15f))
            {
                GameObject spellPrefab = Resources.Load<GameObject>("Spell");

                if (spellPrefab != null)
                {
                    GameObject spell = Object.Instantiate(
                        spellPrefab,
                        origine.position + origine.forward,
                        Quaternion.identity
                    );

                    Rigidbody rb = spell.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.linearVelocity = origine.forward * 15f;
                    }
                }
            }
            else
            {
                Debug.Log("Not enough mana!");
            }
        }
    }
}