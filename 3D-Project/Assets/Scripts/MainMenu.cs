using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
    }


    public void SwitchScene(string SampleScene)
{
        SceneManager.LoadScene("SampleScene");
    }
    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}