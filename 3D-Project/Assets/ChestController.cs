using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    Animator anim;
    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            Pressed();
            Debug.Log("Open Saysame");
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
