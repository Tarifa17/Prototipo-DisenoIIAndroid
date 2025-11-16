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
        Debug.Log("✔ Correcto +20");
        SpawnNuevoObjeto();
    }

    public void ObjetoIncorrecto(GameObject obj)
    {
        Destroy(obj);
        Debug.Log("✖ Incorrecto");
        SpawnNuevoObjeto();
    }

    public void ObjetoPerdido(GameObject obj)
    {
        Destroy(obj);
        Debug.Log("Objeto Perdido");
        SpawnNuevoObjeto();
    }
}
