using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {

    public List<GameObject> Door;
    public SnakeMovment snake;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (snake.score == 10)
            Destroy(Door[0]);
        else if (snake.score == 20)
            Destroy(Door[1]);
        else if (snake.score == 30)
            Destroy(Door[2]);

    }
}
