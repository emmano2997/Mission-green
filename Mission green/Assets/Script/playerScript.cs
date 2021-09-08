using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public  int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    [SerializeField]
    private float moveSpeed = 10f;
    [SerializeField]
    private float gravity = 9.81f;
    [SerializeField]
    private float jumpSpeed = 2.5f;
    [SerializeField]
    private float doubleJumpMultiplier = 1f; 

    private CharacterController controller;

    private float directionY;

    private bool canDoubleJump = false;
    void Start()
    {
        currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

      //  Cursor.lockState = CursorLockMode.Locked; //mouse invisivel 
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        //move and jump script 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (controller.isGrounded)
        {
            canDoubleJump = true;

            if (Input.GetButtonDown("Jump"))
            {
                directionY = jumpSpeed;
            }
        } else {
            if(Input.GetButtonDown("Jump") && canDoubleJump) {
                directionY = jumpSpeed * doubleJumpMultiplier;
                canDoubleJump = false;
            }
        }
        directionY -= gravity * Time.deltaTime;
        direction.y = directionY;
        controller.Move(direction * moveSpeed * Time.deltaTime);
        
        /*/testador de barra de vida 
        if (Input.GetKeyDown(KeyCode.Space))
		{    
			TakeDamage(20);
		}*/
    }   
    //script damage
    void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}
}