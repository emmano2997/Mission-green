using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    
    [SerializeField]CharacterController controller; //controle player;
    [SerializeField] float speed = 5f;  //VelocidadePlayer;
    [SerializeField] public float VelocidadeDeRotação = 5.0f; //rotação de CAM
    public float Sensibilidade = 3.0f; // sensibilidade da CAM
     Rigidbody rb;//Rigidbody
    public Transform playerTransform;
    public Vector3 direction;
    void Update()
    {
        //rb = GetComponent<Rigidbody>(); //Instanciamento do Rigidbody;
        
        //move CAM
        float rotatehoraziontal = Input.GetAxis("Mouse X");
        float rotatevertical = Input.GetAxis("Mouse Y");
        Camera.main.transform.RotateAround(transform.position, Vector3.up, rotatehoraziontal * Sensibilidade);
        Camera.main.transform.RotateAround(transform.position, -Camera.main.transform.right, rotatevertical * Sensibilidade);
        //move player
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical");     

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; //Mover para horizontal, vertical e trava o Eixo Z;
        controller.Move(direction * speed * Time.deltaTime); // Velocidade e direção 
        if (direction.magnitude >= 0.1) //Isso influencia no controle da velocidade do player;
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    } 
}