using UnityEngine;
using System.Collections;

public class TailMovment : MonoBehaviour {
    //Tail of the snake consists of many capsules each capsule follow the other in a linked list

    //this script is given to each capsule
	public float Speed;  //speed of capsule
	public Vector3 tailTarget; //Reference to the capsule in front of her
	public int indx;
	public GameObject tailTargetObj;
	public SnakeMovment mainSnake; //Reference to the main snake movement script
    void Start()
	{
		
		mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovment>();
		tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		indx = mainSnake.tailObjects.IndexOf(gameObject);

	}
	void Update () {
        //update the location of the capsule according to the snake movement speed and the capsule position in the tail
        Speed = mainSnake.Speed + 2.5f;
        tailTarget = tailTargetObj.transform.position;
    	transform.LookAt(tailTarget);
	    transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
        transform.Rotate(90, 0, 0);
        
	}

	void OnCollisionEnter(Collision other)
	{
		//check the collision of the snake with its tail
		if(other.collider.CompareTag("SnakeMain"))
		{
			if(indx > 2)
			{
				//Application.LoadLevel(Application.loadedLevel);
                GameObject.FindGameObjectWithTag("TransitionMenu").GetComponent<TransitionMenu>().lose();
            }
		}

	}
	
}
