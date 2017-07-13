using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SnakeMovment : MonoBehaviour {

	public float Speed;
    public float OriginalSpeed;
    public float SpeedIncrease;
    public float SpeedBonusTime;
    float remaining_Time_For_Bonuse_speed;
    public bool GotSpeedBonus;
	public float RotationSpeed;

	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;
    public int number_of_apples_to_win;
	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
	float stop = 0;
	public bool pausedBoolean = false;
	//public Text[] texts=new Text[2];
	//public Button[] buttons = new Button[4];
	//public GameObject popup;
	TransitionMenu transitionMenu;
	Snake snakeScript;

	void Start ()
	{
		tailObjects.Add(gameObject);
        OriginalSpeed = Speed;
        remaining_Time_For_Bonuse_speed = SpeedBonusTime;

        //transitionMenu = new TransitionMenu(popup,texts,buttons);
        transitionMenu = GameObject.FindGameObjectWithTag("TransitionMenu").GetComponent<TransitionMenu>(); 
        snakeScript = new Snake(transform, RotationSpeed,Speed);
	}

	void Update()
	{
		ScoreText.text = score.ToString();
        if (GotSpeedBonus)
            SpeedBonus();

        if (!transitionMenu.isPlay())
		{
			snakeScript.move(Time.deltaTime);
		}
		else
		{
			snakeScript.stop();
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up  * RotationSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			transitionMenu.play();
			transitionMenu.paused(); 
		}
		else if (score >= number_of_apples_to_win)
		{
			transitionMenu.play();
			transitionMenu.win(100.0f);
		}
		else if (Borders.hitTakePlace)
		{
			// Debug.Log("Borders.hitTakePlace");
			transitionMenu.play();
			transitionMenu.lose();
		}


	}

	public void AddTail()
	{
		score++;
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
    public void SpeedBonus()
    {
        snakeScript.speed = OriginalSpeed + SpeedIncrease;
        Speed = OriginalSpeed + SpeedIncrease;
        remaining_Time_For_Bonuse_speed -= Time.deltaTime;

        if (remaining_Time_For_Bonuse_speed < 0)
        {
            snakeScript.speed = OriginalSpeed;
            Speed = OriginalSpeed;
            remaining_Time_For_Bonuse_speed = SpeedBonusTime;
            GotSpeedBonus = false;
        }

    }
}
