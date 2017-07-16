using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedScriptFunction : MonoBehaviour {

    public void closeTheMenu(GameObject image)
    {
        image.SetActive(false);
    }

    public void quitTheMenu()
    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
    public void reopenGame(GameObject image)
    {
        Borders.hitTakePlace = false;
        closeTheMenu(image);
        Application.LoadLevel(Application.loadedLevel);
    }
    public void nextLeveL(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
