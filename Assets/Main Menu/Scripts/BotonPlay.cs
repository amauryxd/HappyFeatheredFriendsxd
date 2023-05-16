using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonPlay : MonoBehaviour
{
   public void CambioEscena()
    {
        SceneManager.LoadScene(1);
    }
}
