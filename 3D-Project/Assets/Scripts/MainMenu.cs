using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider sliderprogress;

    public void LoadLevel (int SampleScene)
    {
        StartCoroutine(LoadAsynchronously(SampleScene));
    }

    IEnumerator LoadAsynchronously (int SampleScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SampleScene);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress);
            Debug.Log(operation.progress);
            sliderprogress.value = progress;
            yield return null;
        }
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
