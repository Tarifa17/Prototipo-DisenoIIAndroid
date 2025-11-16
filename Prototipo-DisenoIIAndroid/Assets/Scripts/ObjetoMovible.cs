using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Tomar acelerómetro
        Vector3 acc = Input.acceleration;

        // Si el juego está en landscape, hay que remapear
        float moveX = acc.x;
        float moveY = -acc.y;  // se invierte para que “inclinación arriba” mueva hacia arriba

        // Movimiento
        Vector2 movement = new Vector2(moveX, moveY) * speed;

        // Aplicar el movimiento en 2D
        transform.Translate(movement * Time.deltaTime);
    }
}
