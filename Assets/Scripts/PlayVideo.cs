using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]
public class PlayVideo : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
            movie.Pause();
        else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
            movie.Pause();
        else if (Input.GetKeyDown(KeyCode.Escape) && !movie.isPlaying)
        {
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }

    }
}
