using UnityEngine;

public class Axe : IWeapon
{
    public void Attaquer(Transform origine)
    {
        Debug.Log("coup de hache");

        Collider[] hitColliders = Physics.OverlapSphere(origine.position, 3f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(40);
            }
        }
    }
}
