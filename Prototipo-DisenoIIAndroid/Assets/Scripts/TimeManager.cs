using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;

    public float tiempoMaximo = 180f; // 3 minutos
    public float tiempoActual { get; private set; }

    public bool tiempoActivo = true;
    private bool timerIniciado = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        tiempoActual = tiempoMaximo;
        UIManager.instance.ActualizarTiempo(tiempoActual);
    }

    void Update()
    {
        if (!timerIniciado) return;

        tiempoActual -= Time.deltaTime;

        if (tiempoActual <= 0)
        {
            tiempoActual = 0;
            tiempoActivo = false;
            GameManager.instance.FinDelJuego();
        }

        UIManager.instance.ActualizarTiempo(tiempoActual);
    }

    // Llamado desde PauseManager cuando el jugador toca "Comenzar"
    public void IniciarTimer()
    {
        timerIniciado = true;
    }

    // Llamado cuando PauseManager pausa el juego
    public void PausarTimer()
    {
        timerIniciado = false;
    }

    // Llamado cuando PauseManager reanuda el juego
    public void ReanudarTimer()
    {
        timerIniciado = true;
    }

    // Opcional: reset al reiniciar nivel
    public void ReiniciarTimer()
    {
        tiempoActual = tiempoMaximo;
        timerIniciado = false;
        UIManager.instance.ActualizarTiempo(tiempoActual);
    }
}

