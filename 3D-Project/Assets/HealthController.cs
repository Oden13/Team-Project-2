using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class HealthController : MonoBehaviour
{
    public Slider healthBar;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    void OnCollisionEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            //health = health - 1; 
            Debug.Log("Hi There");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
