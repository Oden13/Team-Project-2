using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase : MonoBehaviour
{
 public int speed;
    public GameObject player;
    public float range;
    public Transform playerDistance;

    public AudioClip rock;
    public AudioSource rockSound;



    void Update () 
    {
        if(Vector3.Distance(playerDistance.position,transform.position) <= range)
        {

            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized; // The normalized direction in LOCAL space
            transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
            //transfrom.Lookat(player.transform);
            //transform.position += transform.forward * 3f * Time.deltaTime;

        }
    }

   // void FixedUpdate()
    //{
      //  transform.LookAt(playerDistance);
    //}

    void OnTriggerEnter(Collider other)
    {
     
        if (other.gameObject.CompareTag("fireball"))
        {
            rockSound.clip = rock;
            rockSound.Play();
            Destroy(gameObject,0.6f);
        }
    }
}
