using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {
	public static bool hitTakePlace = false;
	void OnCollisionEnter(Collision other)
    {
		hitTakePlace = true;
		if(other.collider.CompareTag("SnakeMain"))
		{
				Application.LoadLevel(Application.loadedLevel);
		}

	}
}
