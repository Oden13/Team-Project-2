using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectile;
    public Camera cam;
    private Vector3 destination;
    public Transform firePoint;
    public float projectileSpeed;
    public AudioClip shooting;
    public AudioSource shootingSound;
    public float shootForce;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
            shootingSound.clip = shooting;
            shootingSound.Play();
        }
    }
    void FireProjectile()
    {
        //var projectileObj = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        //projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;

        //Instantiate(projectile, transform.position, transform.rotation);

         GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
        shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);

    }
}
