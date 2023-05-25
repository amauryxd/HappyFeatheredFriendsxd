using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (SigAcc > 0)
        {
            SigAcc -= Time.deltaTime;
        }

        if (tp && !esJugador && SigAcc <= 0)
        {
            gameObject.transform.position = new Vector2(0.45f,12.21f);

             SigAcc = coolDown;        
        }
        if (SigAccEscudo > 0)
        {
            SigAccEscudo -= Time.deltaTime;
        }

        if (SigAccEscudo2 > 0)
        {
            SigAccEscudo2 -= Time.deltaTime;
        }

        if (activocorazon && SigAccEscudo <= 0)
        {
            Escudo.SetActive(false);
            esscudo = 0;
            activocorazon = false;
        }
        if (vida == 4) {
            corazones[3].SetActive(true);
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
    public void tomarDaño(float daño)
    {
        Debug.Log("Ejecutar");
        vida -= daño;

        if(vida <= 0)
        {
            Muerte();
        }
    }
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
    }

    public void heal()
    {
        if(vida >= 4)
        {

        }
        else{
            vida += 1;
        }
    }
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
