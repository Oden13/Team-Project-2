using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NAVV : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent nav;
    public float range;
    public Transform playerDistance;

     private Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

          animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(playerDistance.position, transform.position) <= range)
        {
            nav.SetDestination(target.position);

             animator.SetBool("IsWalking", true);
        }
            
    }
}
