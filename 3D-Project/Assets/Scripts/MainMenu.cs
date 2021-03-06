using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
 public void LoadScene(string LoadingScene)
    {
        SceneManager.LoadScene("LoadingScene");
    }

public void LoadMenu (string MainMenu)
{
        SceneManager.LoadScene("MainMenu");
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    void Update()
    {
    }
}