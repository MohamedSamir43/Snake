using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_PowerUp : MonoBehaviour {

    // Use this for initialization
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime * 5);
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.collider.CompareTag("SnakeMain"))
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerUpdate>().increaseTime();
            Destroy(gameObject);
        }

    }
}
