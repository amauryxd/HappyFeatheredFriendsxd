using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ataque : MonoBehaviour
{

    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoSiguienteAtaque;

    public Button but;

    public void Golpe()
    {

        if (tiempoSiguienteAtaque <= 0)
        {
            Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

            foreach (Collider2D colisionador in objetos)
            {
                if (colisionador.CompareTag("Enemy"))
                {
                    colisionador.transform.GetComponent<Vida>().tomarDaño(dañoGolpe);
                }
            }
            tiempoSiguienteAtaque = tiempoEntreAtaques;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoSiguienteAtaque > 0)
        {
            tiempoSiguienteAtaque -= Time.deltaTime;
            but.interactable = false;
        }
        if (tiempoSiguienteAtaque <= 0)
        {
            but.interactable = true;
        }

    }
}
