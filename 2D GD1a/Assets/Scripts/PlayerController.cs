using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float sprintSpeed;    

    public Rigidbody2D rb;

    private Vector2 moveInput;

    public Animator myAnim;

    public static PlayerController instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Our player movement input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // This fixes diagonal movement
        moveInput.Normalize();

        
        // This moves the player and allows for Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = moveInput * sprintSpeed;
        }
        else
        {
            rb.velocity = moveInput * moveSpeed;
        }

       
        // Controls the Blend Tree animator
        myAnim.SetFloat("moveX", rb.velocity.x);
        myAnim.SetFloat("moveY", rb.velocity.y);
                
    }

}
