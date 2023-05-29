using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    public void Menuu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
