using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public void pauseButton() {
        Time.timeScale = 0f;
    }
    public void playButton() {
        Time.timeScale = 1f;
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
