using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public float Speed = 500;
    public AudioSource player_bullet; 

    void Start()
    {
      //  Player_bullet = GetComponent<>(AudioSourse); 
    }
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