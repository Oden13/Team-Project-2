using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase : MonoBehaviour
{
 public int speed;
    public GameObject player;
    public float range;
    public Transform playerDistance;
    public float speedRotation = 1.0f;

   
    void Update () 
    {
        if(Vector3.Distance(playerDistance.position,transform.position) <= range)
        {
         
       
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * speed, 0, localPosition.z * Time.deltaTime * speed);

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
            Destroy(gameObject);
        }
    }
}
