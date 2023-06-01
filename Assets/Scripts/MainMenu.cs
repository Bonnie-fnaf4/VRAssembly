using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }
    public void Quit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    public void Red()
    {
        Quit();
    }

    public void Green()
    {
        StartGame();
    }
}
