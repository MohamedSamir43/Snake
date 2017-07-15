using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {
	public static bool hitTakePlace = false;

    //this script is given to any obstacle in the game
    //The idea is simple

	void OnCollisionEnter(Collision other) //if u are hit by an object
	{
		hitTakePlace = true; 
		if(other.collider.CompareTag("SnakeMain")) // check the tag of the collider if it is the snake
		{
            GameObject.FindGameObjectWithTag("TransitionMenu").GetComponent<TransitionMenu>().lose(); // if it is really the snake display the lose screen
        }

	}
}
