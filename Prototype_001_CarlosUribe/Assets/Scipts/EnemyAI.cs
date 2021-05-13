using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    NavMeshAgent enemy;
    GameObject bullet;


    public float betweenAttacks;
    bool alreadyAttacked;

 


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<NavMeshAgent>();

    
    }

    void Update()
    {
        AttackPlayer();
        enemy.destination = player.transform.position;

       // if (enemy = player.transform.position) AttackPlayer();

    }

    void AttackPlayer()
    {
        enemy.SetDestination(transform.position);
       
    }



}
