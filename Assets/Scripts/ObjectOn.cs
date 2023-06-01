using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectOn : MonoBehaviour
{
    public GameObject[] Object;
    public bool[] isOn;

    public float Timer = 120, ScoreAll = 20;
    public Text TimerText;

    public float Score;
    public Text ScoreText;

    public UI uI;
    private void Update()
    {
        if(uI.MainPanel.activeSelf == false)Timer -= Time.deltaTime;
        TimerText.text = Timer.ToString("0.00") + "";

        ScoreText.text = Score + "/" + ScoreAll;

        if (Timer <= 0) uI.Lose();
        if (Score >= ScoreAll) uI.Win();
    }
    public void OnObject(int id)
    {
        for(int i = 0; i < Object.Length; i++)
        {
            if(Object[i].activeSelf == true && isOn[i] == false)
            {
                return;
            }
        }
        Object[id - 1].SetActive(true);
        ObjectSet objectSet = Object[id - 1].GetComponent <ObjectSet>();
        objectSet.objectOn = this;
        //isOn[id - 1] = true;
    }
}
