using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowMe : MonoBehaviour
{
    GameObject playerFollower;
    NavMeshAgent follower;
    public float Speed = 10;


    void Start()
    {
        playerFollower = GameObject.FindGameObjectWithTag("Player");
        follower = GetComponent<NavMeshAgent>();


    }

    void Update()
    {
        follower.destination = playerFollower.transform.position;
      
    }

}

