using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration_V2 : MonoBehaviour {

    public bool in_Reverese;
    public int index_of_active_food;
    public List<GameObject> Food;
    
	void Start () {
        if (in_Reverese == false)
            Food.Reverse();

		foreach(GameObject i in Food)
            i.SetActive(false);

        index_of_active_food = Food.Count;

        updateFood();

    }
	
	// Update is called once per frame
	
    public void updateFood()
    {
        index_of_active_food--;
        if (index_of_active_food < 0)
            return;
        Food[index_of_active_food].SetActive(true);
    }
}
