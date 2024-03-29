﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private string level;
    private float delaybeforeloading = 5f;
    private float timeElapsed;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delaybeforeloading)
        {
            SceneManager.LoadScene(level);
        }
    }
    }
