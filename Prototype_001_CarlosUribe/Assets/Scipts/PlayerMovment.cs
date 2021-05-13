using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController controller; //refernce to fps object 

    Vector3 velocity;
    Vector3 jump;
    bool isGrounded;
    public float speed = 12f;
    public float jumpHieght = 5f;
    public float gravity = -9.81f;
    public float jumpForce = 20.0f;
    Rigidbody rb;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }


    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            {
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

        }
    }
}
