using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_PowerUP : MonoBehaviour {

    // Use this for initialization
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime * 5);
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.collider.CompareTag("SnakeMain"))
        {
            other.gameObject.GetComponent<SnakeMovment>().GotSpeedBonus = true;
            Destroy(gameObject);
        }

    }
}
