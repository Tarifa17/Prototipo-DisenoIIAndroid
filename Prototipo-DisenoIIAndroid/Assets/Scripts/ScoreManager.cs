using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int puntos { get; private set; }

    private void Awake()
    {
        instance = this;
        puntos = 0;
    }

    public void Sumar(int cantidad)
    {
        puntos += cantidad;
        UIManager.instance.ActualizarPuntos(puntos);
    }

    public void Restar(int cantidad)
    {
        puntos -= cantidad;
        if (puntos < 0) puntos = 0; // opcional
        UIManager.instance.ActualizarPuntos(puntos);
    }
}
