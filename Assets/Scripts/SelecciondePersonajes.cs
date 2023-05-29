using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelecciondePersonajes : MonoBehaviour
{
    [SerializeField] List<Sprite> personajes;

    Image personajeSeleccionado;
    int indicePersonaje = 0;

    private void Start()
    {
        personajeSeleccionado = GetComponent<Image>();
        personajeSeleccionado.sprite = personajes[indicePersonaje];

    }

    public void PersonajeSiguiente()
    {
        indicePersonaje++;
        if (indicePersonaje >= personajes.Count)
        {
            indicePersonaje = 0;
        }

        ActualizarImagen(indicePersonaje);
    }
    public void PersonajeAnterior()
    {
        indicePersonaje--;
        if (indicePersonaje < 0)
        {
            indicePersonaje = personajes.Count -1;
        }
        ActualizarImagen(indicePersonaje);
    }

    private void ActualizarImagen(int indice)
    {
        personajeSeleccionado.sprite = personajes[indice];
    }

    public void Jugar()
    {
        if (indicePersonaje == 0)
        {
            PlayerPrefs.SetInt("indicePersonaje", indicePersonaje);
            SceneManager.LoadScene("Game");
        }
    }

}
