using UnityEngine;
using UnityEngine.InputSystem;

public class AccelerometerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Activar compensación de sensores
        InputSystem.EnableDevice(Accelerometer.current);
    }

    void FixedUpdate()
    {
        if (Accelerometer.current != null)
        {
            // Leer acelerómetro desde el nuevo Input System
            Vector3 acc = Accelerometer.current.acceleration.ReadValue();

            // Remapear según orientación
            float moveX = acc.x;
            float moveY = -acc.y;

            Vector2 movement = new Vector2(moveX, moveY) * speed;
            rb.linearVelocity = movement;
        }
    }
}