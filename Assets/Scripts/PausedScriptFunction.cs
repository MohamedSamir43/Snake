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
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
    public void reopenGame(GameObject image)
    {
        Borders.hitTakePlace = false;
        closeTheMenu(image);
        Application.LoadLevel("Level_1");
    }
    public void nextLeveL(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
