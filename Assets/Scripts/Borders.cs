using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {
	public static bool hitTakePlace = false;

	void OnTriggerEnter(Collider other)
	{
		hitTakePlace = true;
		if(other.CompareTag("SnakeMain"))
		{
				Application.LoadLevel(Application.loadedLevel);
		}

	}
}
