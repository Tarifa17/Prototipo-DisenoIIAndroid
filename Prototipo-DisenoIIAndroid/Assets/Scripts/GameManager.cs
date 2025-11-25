using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState currentState = GameState.Playing;

    public Transform puntoSpawn;
    public GameObject[] prefabsObjetos;

    private GameObject objetoActual;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SpawnNuevoObjeto();
    }

    public void SpawnNuevoObjeto()
    {
        if (currentState != GameState.Playing) return;

        int index = Random.Range(0, prefabsObjetos.Length);

        objetoActual = Instantiate(prefabsObjetos[index], puntoSpawn.position, Quaternion.identity);
    }

    public void ObjetoCorrecto(GameObject obj)
    {
        if (currentState != GameState.Playing) return;

        Destroy(obj);
        ScoreManager.instance.Sumar(20);
        SpawnNuevoObjeto();
    }

    public void ObjetoIncorrecto(GameObject obj)
    {
        if (currentState != GameState.Playing) return;

        Destroy(obj);
        ScoreManager.instance.Restar(10);
        SpawnNuevoObjeto();
    }

    public void ObjetoPerdido(GameObject obj)
    {
        if (currentState != GameState.Playing) return;

        Destroy(obj);
        ScoreManager.instance.Restar(5);
        SpawnNuevoObjeto();
    }
    public void FinDelJuego()
    {
        Debug.Log("⏳ Juego terminado");
        currentState = GameState.Finished;
        Time.timeScale = 0f;

        UIManager.instance.MostrarPantallaFinal(ScoreManager.instance.puntos);
    }
}
