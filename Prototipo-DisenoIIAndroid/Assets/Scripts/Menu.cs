using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        // Carga la escena del juego
        SceneManager.LoadScene("Nivel");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir del juego (solo funciona en build)");
    }
}
