using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionCaptura : MonoBehaviour
{
    [SerializeField] private float coolDown;
    [SerializeField] private float SigAcc;

    public int caso;

    public GameObject[] CC1;
    public GameObject[] CC2;

    public int Tiles = 0;

    public bool on = false;
    public string tagg1;
    public string tagg2;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (SigAcc <= 0 && collision.CompareTag(tagg1) || collision.CompareTag(tagg2))
        {
            on = true;
            Debug.Log("Activar captura");
            //Captura();
            
        }
        if (collision.CompareTag(tagg1) || collision.CompareTag(tagg2))
        {
            CirculosAdentro();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        on = false;
        CirculosApagar();
    }
    void Update()
    {
        if (on && SigAcc <= 0)
        {
            Captura();
            CirculosAdentro();
        }
        if (SigAcc > 0)
        {
            SigAcc -= Time.deltaTime;

        }

        if (Tiles == 5 && caso == 1) {
            SceneManager.LoadScene("Victory");
        }
        if(Tiles == 5 && caso == 2)
        {
            SceneManager.LoadScene("Derrota");
        }
        
    }
    public void Captura()
    {
            Tiles += 1;
            SigAcc = coolDown;
        
    }
    public void CirculosAdentro()
    {
        CC1[0].SetActive(true);
        CC1[1].SetActive(true);
        CC1[2].SetActive(true);
        CC1[3].SetActive(true);
        CC1[4].SetActive(true);
        //los otros

        if (Tiles > 0)
        {
            CC2[0].SetActive(true);
        }
        if (Tiles > 1)
        {
            CC2[1].SetActive(true);
        }
        if (Tiles > 2)
        {
            CC2[2].SetActive(true);
        }
        if (Tiles > 3)
        {
            CC2[3].SetActive(true);
        }
        if (Tiles > 4)
        {
            CC2[4].SetActive(true);
        }
    }
    public void CirculosApagar()
    {
        CC1[0].SetActive(false);
        CC1[1].SetActive(false);
        CC1[2].SetActive(false);
        CC1[3].SetActive(false);
        CC1[4].SetActive(false);

        CC2[0].SetActive(false);
        CC2[1].SetActive(false);
        CC2[2].SetActive(false);
        CC2[3].SetActive(false);
        CC2[4].SetActive(false);
    }
}
