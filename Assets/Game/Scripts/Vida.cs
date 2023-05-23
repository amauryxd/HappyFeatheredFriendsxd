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
        if(true)//poner que cuando detecte el gameobjecto no se active y cooldown
        vida += 1;

    }
}
