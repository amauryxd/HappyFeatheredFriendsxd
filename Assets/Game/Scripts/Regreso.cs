using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regreso : MonoBehaviour
{
    [SerializeField] private float coolDown;
    [SerializeField] private float SigAcc;

    public float x, y, z;

    public GameObject objeto;
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

            regreso();
        }
 

    }
    private void OnMouseDown()
    {
        Debug.Log("toco");
        SigAcc = coolDown;
    }

    public void regreso()
    {
        objeto.transform.position = new Vector3(x, y, z);
    }
}
