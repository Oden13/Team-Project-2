using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
  [SerializeField]  float jumpForce = 500;
 [SerializeField] Transform groundChecker;
[SerializeField] float checkRadius;
[SerializeField] LayerMask groundLayer;

    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown (KeyCode.Space) && IsOnGround ()) 
      {
          rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
      }  

bool IsOnGround() {
    Collider[] colliders = Physics.OverlapSphere(groundChecker.position, checkRadius, groundLayer);
    if (colliders.Length > 0) {
        return true;
    }else {
        return false;
    }
}

    }
}
