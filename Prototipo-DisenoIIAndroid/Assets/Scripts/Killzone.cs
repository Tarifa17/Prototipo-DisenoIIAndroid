using UnityEngine;

public class Killzone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Objeto>())
        {
            GameManager.instance.ObjetoPerdido(other.gameObject);
         
        }
    }
}
