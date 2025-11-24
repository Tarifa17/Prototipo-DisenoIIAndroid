using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
        int index = Random.Range(0, prefabsObjetos.Length);

        objetoActual = Instantiate(prefabsObjetos[index], puntoSpawn.position, Quaternion.identity);
    }

    public void ObjetoCorrecto(GameObject obj)
    {
        Destroy(obj);
        ScoreManager.instance.Sumar(20);
        SpawnNuevoObjeto();
    }

    public void ObjetoIncorrecto(GameObject obj)
    {
        Destroy(obj);
        ScoreManager.instance.Restar(10);
        SpawnNuevoObjeto();
    }

    public void ObjetoPerdido(GameObject obj)
    {
        Destroy(obj);
        ScoreManager.instance.Restar(5);
        SpawnNuevoObjeto();
    }
    public void FinDelJuego()
    {
        Debug.Log("⏳ Juego terminado");
        UIManager.instance.MostrarPantallaFinal(ScoreManager.instance.puntos);
    }
}
