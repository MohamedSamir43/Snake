using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerUpdate : MonoBehaviour
{
    public Text timerText;
    public float myTimer = 90f;
    public float timeIncrease = 5f;
    private bool count_Down = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myTimer -= Time.deltaTime;


        string minutes = ((int)myTimer / 60).ToString();
        string seconds = (myTimer % 60).ToString("f0");

        timerText.text = minutes + " : " + seconds;

    }
    public void increaseTime()
    {
        myTimer += timeIncrease;
    }

}
