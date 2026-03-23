using UnityEngine;

namespace TP2_Heritage
{
    // Version du PlayerCharacter du TP1 pour le TP2
    public class PlayerCharacter : MonoBehaviour
    {
        [SerializeField] private Arme arme;
        [SerializeField] private string playerName;
        [SerializeField] private int health;
        [SerializeField] private int maxHealth = 100;
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private int gold;
        private bool isInvincible;

        // Propriétés encapsulées avec validation
        public string PlayerName { get { return playerName; } }

        public int Health
        {
            get { return health; }
            private set { health = Mathf.Clamp(value, 0, maxHealth); }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            private set { maxHealth = Mathf.Max(1, value); }
        }

        public float MoveSpeed
        {
            get { return moveSpeed; }
            private set { moveSpeed = Mathf.Clamp(value, 0.5f, 20f); }
        }

        public int Gold
        {
            get { return gold; }
            private set { gold = Mathf.Max(0, value); }
        }

        public bool IsInvincible
        {
            get { return isInvincible; }
            private set { isInvincible = value; }
        }

        private void Start()
        {
            // Initialisation avec validation
            Health = maxHealth;
            arme = new ArmeMelee(); // arme par défaut
        }

        void Update()
        {
            if (Health <= 0)
            {
                Die();
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attaquer();
            }

            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }

        // Méthodes publiques avec logique de validation
        public void TakeDamage(int damage)
        {
            if (isInvincible) return;

            if (damage > 0)
                Health -= damage;
        }

        public void Heal(int amount)
        {
            if (amount > 0)
                Health += amount;
        }

        public void GainGold(int amount)
        {
            if (amount > 0)
                Gold += amount;
        }

        private void Die()
        {
            Debug.Log($"Player {PlayerName} is dead!");
            // Logique de mort ici
        }
        void Attaquer()
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, 2f);

            foreach (Collider hit in hits)
            {
                Enemy enemy = hit.GetComponent<Enemy>();

                if (enemy != null)
                {
                    int degats = arme.Attaquer();
                    enemy.TakeDamage(degats);

                    Debug.Log("Attaque avec " + degats + " dégâts");
                }
            }
        }
    }
}