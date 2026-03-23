using UnityEngine;

public class Airplane : Vehicle
{
    public float airplaneLift;

    protected override void Accelerer(float input)
    {
        speed += acceleration * 0.8f * input * Time.deltaTime;
        Comportement_special_acceleration(input);
    }

    protected override void Freiner(float input)
    {
        speed -= brakeForce * 0.4f * Mathf.Abs(input) * Time.deltaTime;
    }

    protected override void Comportement_special_acceleration(float input)
    {
        ApplyAirplaneLift();
    }

    protected override void Gerer_direction(float turnInput, float moveInput)
    {
        transform.Rotate(
            turnInput * handling * 0.5f * Time.deltaTime,
            moveInput * handling * 0.3f * Time.deltaTime,
            -turnInput * handling * Time.deltaTime
        );
    }

    void ApplyAirplaneLift()
    {
        if (speed > maxSpeed * 0.3f)
        {
            float liftForce = airplaneLift * (speed / maxSpeed);
            transform.Translate(Vector3.up * liftForce * Time.deltaTime, Space.World);
        }
    }
}