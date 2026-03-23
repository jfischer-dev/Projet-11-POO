using UnityEngine;

public class Bow : IWeapon
{
    public void Attaquer(Transform origine)
    {
        Debug.Log("flèche tiré");

        GameObject arrowPrefab = Resources.Load<GameObject>("Arrow");
        if (arrowPrefab != null)
        {
            GameObject arrow = Object.Instantiate(
                arrowPrefab,
                origine.position + origine.forward,
                Quaternion.identity
            );

            Rigidbody rb = arrow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = origine.forward * 20f;
            }
        }
    }
}