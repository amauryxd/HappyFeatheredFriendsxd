using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public GameObject obj;
    private void Start()
    {

    }
    public void MAP()
    {
        obj.SetActive(true);
    }
    public void mapch()
    {
        obj.SetActive(false);
    }
}
