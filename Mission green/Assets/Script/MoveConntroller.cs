using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConntroller : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;
    private Vector3 velocity;
    private float gravity = -9.8f;

    void Start()
    {
        
    }

    void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
