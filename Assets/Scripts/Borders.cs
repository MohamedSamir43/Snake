using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {
	public static bool hitTakePlace = false;

	void OnCollisionEnter(Collision other)
	{
		hitTakePlace = true;
		if(other.collider.CompareTag("SnakeMain"))
		{
            GameObject.FindGameObjectWithTag("TransitionMenu").GetComponent<TransitionMenu>().lose();
        }

	}
}
