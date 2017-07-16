using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration_V2 : MonoBehaviour
{
    public bool in_Reverese;
    public int index_of_active_food;
    public List<GameObject> Food;

    //Script the controls the apples for the snake
    //U just drag the apples to the script
    //And each time the snake eats one
    //Another appears

    void Start() // make all apples invisible but the last one
    {
        if (in_Reverese == false)
            Food.Reverse();

        foreach (GameObject i in Food)
            i.SetActive(false);

        index_of_active_food = Food.Count;
        
        updateFood();

    }

    public void updateFood() //it is called one an apple is eaten to tell the list to make the new last apple visible
    {
        index_of_active_food--;
        if (index_of_active_food < 0)
            return;

        Food[index_of_active_food].SetActive(true);
    }
}
