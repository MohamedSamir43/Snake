using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionMenu : MonoBehaviour {
    public Text head;
    public Text body;
    public Button leftButton;
    public Button rightButton;
    public Button newScene;
    public Button retry;
    public GameObject image;
    public TransitionMenu(GameObject image,Text[] texts,Button[] buttons )
    {
        Debug.Log("Constructor");
        this.image = image;
        this.head = (Text)texts[0];
        this.body = (Text)texts[1];
        this.leftButton = (Button)buttons[0];
        leftButton.GetComponentInChildren<Text>().text = "Exit";
        this.rightButton = (Button)buttons[1];
        this.retry = (Button)buttons[2];
        this.newScene = (Button)buttons[3];
    }
    public void win(float score)
    {
        head.text = "You Win";
        body.text = "Congrulation! you score"+score;
        rightButton.gameObject.SetActive(false);
        retry.gameObject.SetActive(false);
        newScene.gameObject.SetActive(true);
        newScene.GetComponentInChildren<Text>().text = "Next Level";
        Borders.hitTakePlace = false;

    }
    public void lose()
    {
        head.text = "You Lose";
        body.text = "you still have chance to be the top";
        rightButton.gameObject.SetActive(false);
        newScene.gameObject.SetActive(false);
        retry.gameObject.SetActive(true);
        retry.GetComponentInChildren<Text>().text = "Play Again";
    }
    public void paused()
    {
        head.text = "Pause";
        body.text = "we are waiting for you ^_^";
        rightButton.GetComponentInChildren<Text>().text = "Continue";
        rightButton.gameObject.SetActive(true);
        newScene.gameObject.SetActive(false);
        retry.gameObject.SetActive(false);
    }
    public void play()
    {
        image.SetActive(true);
    }
    public void stop()
    {
        Debug.Log("Stop");
        image.SetActive(false);
    }
    public bool isPlay(){return image.activeSelf;}

   
	
}
