using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SnakeMovment : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;
    public int number_of_apples_to_win;
	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
    float stop = 0;
    public bool paused = false;
    public GameObject popup;
	void Start () {
	tailObjects.Add(gameObject);
	}
    void move()
    {

    }
    void Update()
    {
        ScoreText.text = score.ToString();
        
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.P)&&!paused)
        {
            popup.SetActive(true);
            Transform child = popup.transform.Find("TotalScore");
            Text t = child.GetComponent<Text>();
            t.text = "Total Score = "+score + "";
            paused = true;
            stop = Speed;
            Speed = 0;
        }
        else if (Input.GetKeyDown(KeyCode.P) && paused)
        {
            popup.SetActive(false);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            paused = false;
            Speed = stop;
        }
        else if (score >= number_of_apples_to_win)
        {
            SceneManager.LoadScene("LevelTwo");
        }
        

    }

	public void AddTail()
	{
		score++;
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
}
