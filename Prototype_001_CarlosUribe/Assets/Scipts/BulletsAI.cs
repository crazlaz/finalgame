using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsAI : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public float Speed = 500;
    public AudioSource Enemy_bullet;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet();
        }
    }

    void Bullet()
    {

        var projectile = Instantiate(bulletPrefab, transform.position, transform.rotation);


        projectile.velocity = transform.forward * Speed;
    }
}