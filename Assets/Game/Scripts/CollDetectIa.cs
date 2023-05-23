using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollDetectIa : MonoBehaviour
{
    public bool IACOL;

    private void OnTriggerStay2D(Collider2D collision)
    {
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

    private void OnTriggerExit2D(Collider2D collision)
    {
 
            IACOL = false;
        
    }

}
