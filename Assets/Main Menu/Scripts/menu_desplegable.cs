using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_desplegable : MonoBehaviour
{
    public float desp;
    bool presionado = false;
    public void Mover()
    {
        if (presionado == false)
        {
            transform.position = new Vector2(transform.position.x + desp, transform.position.y);
            presionado = true;
        }
        else
        {
            transform.position = new Vector2(transform.position.x - desp, transform.position.y);
            presionado = false;
        }
    }
}
