using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject MainPanel, Continue, ButtomPause;
    //public GameObject ListObject;

    public Text RestartText, MainMenuText, TitlePanel;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(true);
        //ListObject.SetActive(false);
        ButtomPause.SetActive(false);
        Continue.SetActive(true);
        TitlePanel.text = "�����";
        RestartText.text = "������ ������";
        MainMenuText.text = "������� ����";
    }

    public void Win()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(true);
        Continue.SetActive(false);
        //ListObject.SetActive(false);
        ButtomPause.SetActive(false);
        TitlePanel.text = "������";
        RestartText.text = "������ ������";
        MainMenuText.text = "������� ����";
    }

    public void Lose()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(true);
        Continue.SetActive(false);
        //ListObject.SetActive(false);
        ButtomPause.SetActive(false);
        TitlePanel.text = "���������";
        RestartText.text = "������ ������";
        MainMenuText.text = "������� ����";
    }

    public void MainMenu()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(true);
        Continue.SetActive(false);
        //ListObject.SetActive(false);
        ButtomPause.SetActive(false);
        TitlePanel.text = "������� ����";
        RestartText.text = "������ ����";
        MainMenuText.text = "����� �� ����";
    }

    public void ContinueVoid()
    {
        Time.timeScale = 1;

        MainPanel.SetActive(false);
        //ListObject.SetActive(true);
        ButtomPause.SetActive(true);
    }

    public void RestarVoid()
    {
        Time.timeScale = 1;

        Application.LoadLevel(1);
    }

    public void MainMenuVoid()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }

    public void Yellow()
    {
        if(MainPanel.activeSelf == false)
        {
            Pause();
        }
        else
        {
            if(TitlePanel.text == "���������" || TitlePanel.text == "������") 
            {

            }
            else
            {
                ContinueVoid();
            }
        }
    }

    public void Red()
    {
        if (MainPanel.activeSelf == true)
        {
            MainMenuVoid();
        }
    }

    public void Green()
    {
        if (MainPanel.activeSelf == true)
        {
            RestarVoid();
        }
    }

}
