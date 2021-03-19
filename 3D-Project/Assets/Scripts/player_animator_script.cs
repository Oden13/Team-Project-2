using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animator_script : MonoBehaviour
{
    private Animator animator = null;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetButton("Horizontal"))
        {
            animator.SetBool("IsMoving", true);
        }
  if (Input.GetButton("Vertical"))
        {
            animator.SetBool("IsMoving", true);
        }
        else{animator.SetBool("IsMoving", false);}
 
       
       if (Input.GetKeyDown (KeyCode.Space))
       {
           animator.SetBool("IsJumping", true);

       }
        if (Input.GetKeyUp (KeyCode.Space))
       {
           animator.SetBool("IsJumping", false);
       }
       if(Input.GetButtonDown("Fire1"))
       {
           animator.SetBool("IsAttacking", true);
       }
     if(Input.GetButtonUp("Fire1"))
       {
           animator.SetBool("IsAttacking", false);
       }
 if (Input.GetKeyDown ("x"))
       {
           animator.SetBool("IsCrouching", true);

       }

       if (Input.GetKeyUp ("x"))
       {
           animator.SetBool("IsCrouching", false);

       }

    }
}
