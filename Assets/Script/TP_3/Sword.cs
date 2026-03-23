using UnityEngine;

public class Sword : IWeapon
{
    public void Attaquer(Transform origine)
    {
        Debug.Log("Slash épée");

        Collider[] hitColliders = Physics.OverlapSphere(origine.position, 2f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(25);
            }
        }
    }
}