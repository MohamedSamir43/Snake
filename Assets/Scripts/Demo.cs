using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour {
    public Text textsPanel;
    public GameObject menu;
    public GameObject[] fences;
    Snake snake;
    bool hitTakePlace;
	// Use this for initialization
    void Start()
    {
        textsPanel.text = "Welcome! to make the snake rotate you should use the right and the left arrows \nplease note once you run the snake wouldn't stop until you reach the goal. ";
    }
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < fences.Length; i++)
        {
            if (Mathf.Abs(snake.transform.position.z - fences[i].transform.position.z) < 0.9f)
            {
                hitTakePlace = true;
            }

        }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            {
                textsPanel.text = "now you should eat the apple";
                return;
            }
        if (hitTakePlace)
        {
           textsPanel.text = "Avoid to hit the border or the snake tail to avoid losing";
           hitTakePlace = false;
           return;
        }
        if(Food.hitTakePlace)
        {
            textsPanel.text = "now you want to pause press P \n Note to return to the tutorial click continue else click exit";
            Food.hitTakePlace = false;
            
        }
        textsPanel.text = "Now you are ready to play \nnote to pause you have to click p \n press space bar to go to the first level.";
        


	}
}
