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

    public AudioClip grunt;
    public AudioSource grunting;

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
        if (health == 0)
        {
            Death();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            grunting.clip = grunt;
            grunting.Play();
            health = health - 1;
            Debug.Log("Hi there");
        }
        if (health == 0)
        {
            Destroy(this.gameObject);
            healthBar.value = 0;
            //SceneManager.LoadScene("LoseScreen");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            health = health - 1;
            grunting.clip = grunt;
            grunting.Play();
        }
        if (collider.gameObject.tag == "DeathPlane")
        {
            SceneManager.LoadScene("LoseScreen");
            grunting.clip = grunt;
            grunting.Play();
        }
    }
    void Death()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
