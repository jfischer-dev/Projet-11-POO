using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacterBroken : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où
        [SerializeField] private string playerName;

        [SerializeField] private int health;

        [SerializeField] private int maxHealth = 100;

        [SerializeField] private float moveSpeed;

        [SerializeField] private int maxSpeed = 10;

        [SerializeField] protected int gold;

        private bool isInvincible;

        // Setter
        public void Set_Player_Name(string valeur)
        {
            playerName = valeur;
        }

        public void Set_Health(int valeur)
        {
            health = Mathf.Clamp(valeur, 0, maxHealth);
        }

        public void Set_Move_Speed(float valeur)
        {
            moveSpeed = Mathf.Clamp(valeur, 0, maxSpeed);
        }

        public void Set_Is_Invincible(bool valeur)
        {
            isInvincible = valeur;
        }

        // Getter        
        public int Get_Health()
        {
            return health;
        }
        public float Get_Move_Speed()
        {
            return moveSpeed;
        }

        public int Get_Gold()
        {
            return gold;
        }

        public bool Get_Is_Invincible()
        {
            return isInvincible;
        }


        void Start()
        {
            Set_Health(maxHealth);
        }

        void Update()
        {
            health = Mathf.Clamp(health, 0, maxHealth);
            if (health <= 0)
            {
                Debug.Log("Player is dead");
                Set_Move_Speed(0);
                Set_Is_Invincible(true);
            }

            moveSpeed = Mathf.Clamp(moveSpeed, 0, maxSpeed);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        public void GainGold(int amount)
        {
            gold += amount;
            Debug.Log(Get_Gold());
        }

        public void Spend_Gold(int price)
        {
            Get_Gold();

            if (gold >= price)
            {
                gold -= price;
                Debug.Log(Get_Gold());
            }
        }

        // Méthode nécessaire pour les autres TPs, mais mal implémentée
        public void TakeDamage(int amount)
        {
            if (isInvincible)
            {
                return;
            }

            Set_Health(health - amount);
        }
    }
}