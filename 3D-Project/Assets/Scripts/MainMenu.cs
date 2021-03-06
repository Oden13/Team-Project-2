using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   public Image whiteFade;

void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
    }


    public void LoadScene(string LoadingScene)
    {
        SceneManager.LoadScene("LoadingScene");
    }

public void LoadMenu (string MainMenu)
{
        SceneManager.LoadScene("MainMenu");
        whiteFade.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
    }

    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    void fadeIn()
    {
        whiteFade.CrossFadeAlpha(0, 2, false);
    }
}