using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEn : MonoBehaviour
{
    public GameObject[] mov;

    [SerializeField] private float coolDown;
    [SerializeField] private float SigAcc;

    public static bool colIA;

    //Ataques
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoSiguienteAtaque;

    [SerializeField] public string tagg;
    [SerializeField] public string tagg2;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (SigAcc > 0)
        {
            SigAcc -= Time.deltaTime;
        }

        if (SigAcc <= 0)
        {
            Deci();
            
            SigAcc = coolDown;
        }
        if (tiempoSiguienteAtaque > 0)
        {
            tiempoSiguienteAtaque -= Time.deltaTime;
        }
    }

    public void Deci()
    {
        int ch = Random.Range(1,10);
        switch (ch)
        {
            case 1:
                if (!mov[0].GetComponent<CollDetectIa>().IACOL)
                {
                    gameObject.transform.position = mov[0].transform.position;
                }
                else
                {
                    Debug.Log("nomueve" + mov[0]);
                }
                break;
            case 2:
                if (!mov[1].GetComponent<CollDetectIa>().IACOL)
                {
                    gameObject.transform.position = mov[1].transform.position;
                }
                else
                {
                    Debug.Log("nomueve" + mov[1]);
                }
                break;
            case 3:
                if (!mov[2].GetComponent<CollDetectIa>().IACOL)
                {
                    gameObject.transform.position = mov[2].transform.position;
                }
                else
                {
                    Debug.Log("nomueve" + mov[2]);
                }
                break;
            case 4:
                if (!mov[3].GetComponent<CollDetectIa>().IACOL)
                {
                    gameObject.transform.position = mov[3].transform.position;
                }
                else
                {
                    Debug.Log("nomueve" + mov[3]);
                }
                break;
            case 5:
                if (!mov[4].GetComponent<CollDetectIa>().IACOL)
                {
                    gameObject.transform.position = mov[4].transform.position;
                }
                else
                {
                    Debug.Log("nomueve" + mov[4]);
                }
                break;
            case 6:
                Regresar();
                break;
            case 7:
                HealE();
                break;
            case 8:
                ShieldE();
                break;
            case 9:
                Ataq();
                break;
            default:
                Debug.Log("estonodeberiasalir");
                break;
        }
    }

    public void HealE()
    {
        gameObject.GetComponent<Vida>().heal();
    }

    public void ShieldE()
    {
        gameObject.GetComponent<Vida>().shield();
        //Debug.Log("Escudo");
    }

    public void Ataq()
    {
        if (tiempoSiguienteAtaque <= 0)
        {
            Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

            foreach (Collider2D colisionador in objetos)
            {
                if (colisionador.CompareTag(tagg) || colisionador.CompareTag(tagg2))
                {
                    colisionador.transform.GetComponent<Vida>().tomarDaño(dañoGolpe);
                }
            }
            tiempoSiguienteAtaque = tiempoEntreAtaques;
        }
        //Debug.Log("ataq");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }

    public void Regresar()
    {
        Debug.Log("regreso");
    }




}
