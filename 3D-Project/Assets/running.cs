using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : MonoBehaviour
{
    public AudioClip run;
    public AudioSource stepSound;

    // Start is called before the first frame update
    void Start()
    {

    }


   
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            stepSound.clip = run;
            stepSound.Play();
            stepSound.loop = true;
        }
        if (Input.GetKeyUp("w"))
        {
            stepSound.Stop();
            stepSound.loop = false;
        }
    }
}
