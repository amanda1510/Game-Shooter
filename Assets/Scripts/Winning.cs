using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    public void Play() { SceneManager.LoadScene("Main"); }
    public void MainMenu() { SceneManager.LoadScene("Menu"); }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene("Finish");
    }
}
