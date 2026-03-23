using UnityEngine;

public class Car : Vehicle
{
    public float carTraction;

    protected override void Comportement_special_acceleration(float input)
    {
        ApplyCarTraction();
    }

    protected override void Gerer_direction(float turnInput, float moveInput)
    {
        transform.Rotate(0, turnInput * handling * speed * 0.1f * Time.deltaTime, 0);
    }

    void ApplyCarTraction()
    {
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 1.0f))
        {
            float surfaceFactor = 1.0f;
            if (hit.collider.CompareTag("Dirt")) surfaceFactor = 0.7f;
            if (hit.collider.CompareTag("Ice")) surfaceFactor = 0.3f;

            speed *= (1.0f - (1.0f - carTraction) * (1.0f - surfaceFactor));
        }
    }
}