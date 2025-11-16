using UnityEngine;

public class Contenedor : MonoBehaviour
{
    public string tipoCorrecto;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Objeto obj = other.GetComponent<Objeto>();

        if (obj != null)
        {
            if (obj.tipo == tipoCorrecto)
            {
                Debug.Log("✔ Objeto correcto!");

                GameManager.instance.ObjetoCorrecto(other.gameObject);
            }
            else
            {
                Debug.Log("✖ Incorrecto");

                GameManager.instance.ObjetoIncorrecto(other.gameObject);
            }
        }
    }
}
