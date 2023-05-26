using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollDetectIa : MonoBehaviour
{
    public bool IACOL;
    //funcion para detectar los collider del movimiento para las IA
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Detecta si esta tocando una caja, si es el caso manda true, si no esta tocando nada, manda false
        if (collision.CompareTag("Box"))
        {
            MoveEn.colIA = true;
            IACOL = true;
        }
        else
        {
            MoveEn.colIA = false;
            IACOL = false;
        }
    }
    //actualiza a false cuando deja de tocar
    private void OnTriggerExit2D(Collider2D collision)
    {
 
            IACOL = false;
        
    }

}
