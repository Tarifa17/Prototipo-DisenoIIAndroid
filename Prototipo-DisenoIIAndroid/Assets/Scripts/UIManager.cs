using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TMP_Text textoPuntos;
    public TMP_Text textoTiempo;

    public GameObject pantallaFinal;
    public TMP_Text textoFinal;

    private void Awake()
    {
        instance = this;
    }

    public void ActualizarPuntos(int puntos)
    {
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void ActualizarTiempo(float tiempo)
    {
        int minutos = Mathf.FloorToInt(tiempo / 60);
        int segundos = Mathf.FloorToInt(tiempo % 60);
        textoTiempo.text = $"{minutos:00}:{segundos:00}";
    }

    public void MostrarPantallaFinal(int puntos)
    {
        pantallaFinal.SetActive(true);
        textoFinal.text = "¡Tiempo terminado!\nPuntaje final: " + puntos;
    }
}
