using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenu;
   


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void LoadMainMenu(string LoadingSceneTwo)
    {
        SceneManager.LoadScene("LoadingSceneTwo");
        Time.timeScale = 1f;
    }
    public void RestartScene(string SampleScene)
    {
        SceneManager.LoadScene("LoadingScene");
        Time.timeScale = 1f;
    }
}
