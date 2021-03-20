using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    private float timeBtwDamage;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }
        healthBar.value = health;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            health = health - 1;
            Debug.Log("Hi there");
        }
        if (health == 0)
        {
            Destroy(this.gameObject);
            //Instantiate(deathEffect, transform.position, Quaternion.identity);
            healthBar.value = 0;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            health = health - 1;
        }
        if (collider.gameObject.tag == "DeathPlane")
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
