using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{

    public void Update() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PauseGame() {
        Time.timeScale = 0;
    }

    public void Resume() {
        Time.timeScale = 1;
    }

    public void StartNewGame() {
        SceneManager.LoadScene(1);
    }

    public void credit() {
        SceneManager.LoadScene(5);
    }
}
