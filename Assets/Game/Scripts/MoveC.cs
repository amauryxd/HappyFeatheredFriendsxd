using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveC : MonoBehaviour
{
    GameObject playerpos;
    bool isCol;

    // Start is called before the first frame update
    void Start()
    {
        playerpos = GameObject.FindGameObjectWithTag("Player");
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
    
       void OnMouseDown()
    {
        //Debug.Log("toco");
        if (!isCol)
        {
            playerpos.transform.position = gameObject.transform.position;
        }
        else
        {
            Debug.Log("establock");
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            isCol = true;
        }
        else
        {
            isCol = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (!collision.CompareTag("box"))
        {
            isCol = false;
        }
    }

}
