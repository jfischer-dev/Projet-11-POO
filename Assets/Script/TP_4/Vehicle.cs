using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public float acceleration;
    public float handling;
    public float brakeForce;

    protected virtual void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        Gerer_mouvement(moveInput);
        Gerer_direction(turnInput, moveInput);

        speed = Mathf.Clamp(speed, 0, maxSpeed);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Gerer_mouvement(float moveInput)
    {
        if (moveInput > 0)
        {
            Accelerer(moveInput);
        }
        else if (moveInput < 0)
        {
            Freiner(moveInput);
        }
    }

    protected virtual void Accelerer(float input)
    {
        speed += acceleration * input * Time.deltaTime;
        Comportement_special_acceleration(input);
    }

    protected virtual void Freiner(float input)
    {
        speed -= brakeForce * Mathf.Abs(input) * Time.deltaTime;
    }

    protected abstract void Gerer_direction(float turnInput, float moveInput);
    protected abstract void Comportement_special_acceleration(float input);
}