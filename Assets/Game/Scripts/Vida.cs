using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [SerializeField] private float vida;

    [SerializeField] bool esJugador;
    bool tp;

    [SerializeField] private float coolDown;
    [SerializeField] private float SigAcc;

    public GameObject[] corazones;
    public GameObject Escudo;

    public static int esscudo;
    bool activocorazon = false;

    [SerializeField] private float coolDownEscudo;
    [SerializeField] private float SigAccEscudo;


    [SerializeField] private float coolDownEscudo2;
    [SerializeField] private float SigAccEscudo2;

    public Button butH;
    public Button butS;

    [SerializeField] private float coolDownHeal;
    [SerializeField] private float SigAccHeal;

    // Update is called once per frame
    void Update()
    {
        //cooldown de reaparicion
        if (SigAcc > 0)
        {
            //timer
            SigAcc -= Time.deltaTime;
        }
        //Reaparicion de los enemigos
        if (tp && !esJugador && SigAcc <= 0)
        {
            //tp del enemigo a su posicion original
            gameObject.transform.position = new Vector2(0.45f,12.21f);
            //timer reset
            SigAcc = coolDown;        
        }
        //Duracion del escudo activo
        if (SigAccEscudo > 0)
        {
            //timer
            SigAccEscudo -= Time.deltaTime;

            
        }
        //Cooldown del escudo para volver a usarlo
        if (SigAccEscudo2 > 0)
        {
            //timer
            SigAccEscudo2 -= Time.deltaTime;

            butS.interactable = false;
        }
        //deteccion de que se puede volver a usar el boton de shield
        if (SigAccEscudo2 <= 0)
        {
            butS.interactable = true;
        }

        //Cooldown de heal para volver a usarlo
        if (SigAccHeal > 0)
        {
            //timer
            SigAccHeal -= Time.deltaTime;

            butH.interactable = false;
        }
        //deteccion de que se puede volver a usar el boton de heal
        if (SigAccHeal <= 0)
        {
            butH.interactable = true;
        }
        //Para detectar cuando se activa el escudo recibas menos danio
        if (activocorazon && SigAccEscudo <= 0)
        {
            Escudo.SetActive(false);
            esscudo = 0;
            activocorazon = false;
        }
        //deteccion de cuanta vida tiene para ir quitando los corazones poco a poco
        if (vida == 4) {
            corazones[3].SetActive(true);
            corazones[2].SetActive(true);
            corazones[1].SetActive(true);
            corazones[0].SetActive(true);
        }
        if(vida== 3)
        {
            corazones[3].SetActive(false);
            corazones[2].SetActive(true);
        }
        if (vida == 2)
        {
            corazones[2].SetActive(false);
            corazones[1].SetActive(true);
        }
        if (vida == 1)
        {
            corazones[1].SetActive(false);
            corazones[0].SetActive(true);
        }


    }
    //funcion para recibir danio
    public void tomarDaño(float daño)
    {
        //Debug.Log("Ejecutar");
        vida -= daño;

        if(vida <= 0)
        {
            Muerte();
        }
    }
    //funcion de muerte
    public void Muerte()
    {
        if (esJugador)
        {
            gameObject.transform.position = new Vector2(0,-2.7f);
        }
        else
        {
            gameObject.transform.position = new Vector2(-10, 10);
            tp = true;
        }

        vida = 4;
        corazones[0].SetActive(true);
        corazones[1].SetActive(true);
        corazones[2].SetActive(true);
        corazones[3].SetActive(true);
    }

    //funcion para curarse
    public void heal()
    {
        if (SigAccHeal <= 0)
        {
            if (vida >= 4)
            {

            }
            else
            {
                vida += 1;
            }
            SigAccHeal = coolDownHeal;
        }
    }
    //funcion para ponerse escudo
    public void shield()
    {
        if (!activocorazon && SigAccEscudo2 <= 0)
        {
            Escudo.SetActive(true);
            esscudo = 1;
            SigAccEscudo = coolDownEscudo;
            activocorazon = true;
            SigAccEscudo2 = coolDownEscudo2;
        }


    }
}
