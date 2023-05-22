using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    [SerializeField] private float vida;

    

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tomarDaño(float daño)
    {
        vida -= daño;

        if(vida <= 0)
        {
            Muerte();
        }
    }
    public void Muerte()
    {
        //tp
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
}
