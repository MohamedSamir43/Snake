using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {
    public float rotationSpeed;
    public float speed;
    public Transform snake;
    public Snake(Transform snake,float rotationspeed,float speed)
    {
        this.rotationSpeed=rotationSpeed;
        this.speed=speed;
        this.snake=snake;
    }
    public void move(float time) { 
        snake.Translate(Vector3.forward * speed * time);
    }
    public void stop() {
        snake.Translate(Vector3.zero);
    }
    
}
