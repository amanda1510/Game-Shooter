using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void Play() { SceneManager.LoadScene("Main"); }
    public void MainMenu() { SceneManager.LoadScene("Menu"); }
    public void Win() { SceneManager.LoadScene("Finish"); }
    public void CaraBermain() { SceneManager.LoadScene("HowtoPlay"); }
    public void ExitGame() { Application.Quit(); }
}
