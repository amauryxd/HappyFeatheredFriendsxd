using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class derrota : MonoBehaviour
{
    public Text Text;
    public Text Text2;
    public Text Text3;
    void Start()
    {
        int randomNum = Random.Range(50, 100);
        Text.text = "Puntos de Clasificación: " + randomNum.ToString();

        int randomNum2 = Random.Range(50, 100);
        Text2.text = "Maestria de pájaro: " + randomNum2.ToString();

        int randomNum3 = Random.Range(50, 100);
        Text3.text = "Experiencia: " + randomNum3.ToString();

    }
}