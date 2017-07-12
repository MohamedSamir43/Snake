using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
	public static bool hitTakePlace = false;
	void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("SnakeMain"))
        {
			hitTakePlace = true;
            other.GetComponent<SnakeMovment>().AddTail();
            Destroy(gameObject);
            GameObject.FindWithTag("FoodGenerator").GetComponent<FoodGeneration_V2>().updateFood();
        }
	}
    private void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime*20);
    }

}
