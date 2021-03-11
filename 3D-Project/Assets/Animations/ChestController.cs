﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    Animator anim;
    private bool isOpen;
    public bool isNear;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isNear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isNear == true)
        {

            if (Input.GetKeyDown(KeyCode.M))
            {
                Pressed();
                Debug.Log("Open Saysame");
            }
        }
        else
        {
            isNear = false;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            isNear = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            isNear = false;
        }
    }

   void Pressed()
    {
 
                //This will set the bool the opposite of what it is.
                isOpen = !isOpen;
                
 
                //This line will set the bool true so it will play the animation.
                anim.SetBool("isOpen", !isOpen);
    }
}
