using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen2 : MonoBehaviour
{
    [SerializeField] private string MainMenu;
    private float delaybeforeloading = 3f;
    private float timeElapsed;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delaybeforeloading)
        {
            SceneManager.LoadScene(MainMenu);
        }
    }
    }
