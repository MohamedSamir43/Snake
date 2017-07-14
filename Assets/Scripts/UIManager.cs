using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip Clip;
    public void start()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Level2"));
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Level3"));


    }
    //Play Sound On Button Click
    public void ButtonSound()
    {
        Source.PlayOneShot(Clip);

    }
	// Load Game Scene on Start Button Click
    public void LoadScene(string SceneGame)
    {
        Application.LoadLevel(SceneGame);
    }

    public void Quit()
    {
        //if playing in Unity Editor 
        UnityEditor.EditorApplication.isPlaying = false;

        /* if playing on Build 
        Application.Quit(); */


    }
}
