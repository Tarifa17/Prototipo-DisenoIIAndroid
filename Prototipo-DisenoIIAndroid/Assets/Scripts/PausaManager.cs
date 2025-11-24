using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaManager : MonoBehaviour
{
    public GameObject pausePanel;     // Panel de pausa
    public GameObject instruccionesPanel; // Panel de instrucciones

    private bool juegoIniciado = false;
    private bool enPausa = false;

    private void Start()
    {
        // Mostrar instrucciones al inicio
        Time.timeScale = 0f;
        instruccionesPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    // Llamado desde el botón "Comenzar"
    public void IniciarJuego()
    {
        instruccionesPanel.SetActive(false);
        Time.timeScale = 1f;
        juegoIniciado = true;

        // Activar timer recién ahora
        TimeManager.instance.IniciarTimer();
    }

    public void Pausar()
    {
        if (!juegoIniciado) return; // No pausar si ni empezó

        enPausa = true;
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void Reanudar()
    {
        enPausa = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VolverAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
