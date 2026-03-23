using UnityEngine;

public class Motorcycle : Vehicle
{
    public float motorcycleLeanAngle;

    protected override void Accelerer(float input)
    {
        speed += acceleration * 1.2f * input * Time.deltaTime;
        Comportement_special_acceleration(input);
    }

    protected override void Freiner(float input)
    {
        speed -= brakeForce * 0.8f * Mathf.Abs(input) * Time.deltaTime;
    }

    protected override void Comportement_special_acceleration(float input)
    {
        // Rien ici
    }

    protected override void Gerer_direction(float turnInput, float moveInput)
    {
        transform.Rotate(0, turnInput * handling * speed * 0.15f * Time.deltaTime, 0);
        ApplyMotorcycleLean(turnInput);
    }

    void ApplyMotorcycleLean(float turnInput)
    {
        float targetLean = -turnInput * motorcycleLeanAngle;
        Vector3 currentRotation = transform.localEulerAngles;

        currentRotation.z = Mathf.LerpAngle(currentRotation.z, targetLean, Time.deltaTime * 2.0f);
        transform.localEulerAngles = currentRotation;
    }
}