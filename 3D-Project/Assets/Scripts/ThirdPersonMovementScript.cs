﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovementScript : MonoBehaviour
{
   public CharacterController controller;
   public Transform cam;
   public float speed = 6f;
   public float turnSmoothTime = 0.1f;
   float turnSmoothVelocity;
   Vector3 velocity;
   public float gravity = -9.81f;
   public Transform groundCheck;
   public float groundDistance = 0.4f;
   public LayerMask groundMask;
   bool isGrounded;
   public float jumpHeight = 3f;
   public float slideLength;
    public float slideVelocity;
    public float slideHeight;
    private bool isSliding;
    private float originalHeight;
    public AudioClip jump;
    public AudioClip run;
    public AudioSource Sound;
    private bool isRuning;

    public AudioClip Crouch;



    void Start()
    {
        originalHeight = controller.height;
    }

    // Update is called once per frame
    void Update()
    {
isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
if (isGrounded && velocity.y <0)
{
    velocity.y = -2f;
}
if(Input.GetButtonDown("Jump") && isGrounded)
{
    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    Sound.clip = jump;
    Sound.Play();

        }
        //if (!isGrounded)
        //{
        //  Sound.clip = jump;
        //  Sound.Play();
        //  Sound.Stop();
        // }



        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (isGrounded && Input.GetKeyDown("x"))
        {
                controller.height = slideHeight;
                Sound.clip = Crouch;
                Sound.Play();
                //float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                //Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                //controller.Move(moveDir.normalized * slideVelocity);   
        }
        if (Input.GetKeyUp("x"))
        {
            controller.height = originalHeight;
            Sound.clip = Crouch;
            Sound.Play();
        }
       
    }

   // void FixedUpdate()
   // {
        //if (Input.GetKeyDown("space"))
        //{
          //Sound.clip = jump;
          // Sound.Play();
       // }
        //if (Input.GetKeyUp("space"))
        //{ 
          //  Sound.loop = false;
        //}
        //if (Input.GetKeyDown("w") && !Sound.isPlaying)
       // {

          // Sound.clip = run;
          //  Sound.Play();
           // Sound.loop = true;
       // 
        //}

    //}
}
