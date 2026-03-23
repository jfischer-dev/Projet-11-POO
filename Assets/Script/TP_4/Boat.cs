using UnityEngine;

public class Boat : Vehicle
{
    public float boatBuoyancy;

    protected override void Accelerer(float input)
    {
        speed += acceleration * 0.7f * input * Time.deltaTime;
        Comportement_special_acceleration(input);
    }

    protected override void Freiner(float input)
    {
        speed -= brakeForce * 0.6f * Mathf.Abs(input) * Time.deltaTime;
    }

    protected override void Comportement_special_acceleration(float input)
    {
        ApplyBoatBuoyancy();
    }

    protected override void Gerer_direction(float turnInput, float moveInput)
    {
        transform.Rotate(0, turnInput * handling * speed * 0.05f * Time.deltaTime, 0);
    }

    void ApplyBoatBuoyancy()
    {
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 2.0f))
        {
            if (hit.collider.CompareTag("Water"))
            {
                float desiredHeight = hit.point.y + boatBuoyancy;
                Vector3 pos = transform.position;

                pos.y = Mathf.Lerp(pos.y, desiredHeight, Time.deltaTime * 2.0f);
                transform.position = pos;
            }
        }
    }
}