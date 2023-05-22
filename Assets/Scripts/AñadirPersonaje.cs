using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AñadirPersonaje : MonoBehaviour
{
    [SerializeField] List<GameObject> personajes;
    // Start is called before the first frame update
    void Start()
    {
        var indice = PlayerPrefs.GetInt("indicePersonaje");
        Instantiate(personajes[indice], transform);
    }

   
}
