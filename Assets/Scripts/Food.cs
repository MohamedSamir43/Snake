using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
	public static bool hitTakePlace = false;

	void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("SnakeMain"))
        {
			hitTakePlace = true;
            other.GetComponent<SnakeMovment>().AddTail(); //it alerts the snake to add a new capsule to its tail

            Destroy(gameObject);
            GameObject.FindWithTag("FoodGenerator").GetComponent<FoodGeneration_V2>().updateFood(); //it alerts the food generator that an apple is eaten
        }
	}
    private void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime*20);
    }

}
