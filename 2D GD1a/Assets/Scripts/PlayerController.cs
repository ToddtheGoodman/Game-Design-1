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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Old movement script
        //transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * Input.GetAxis("Horizontal"));
        //transform.Translate(Vector2.up * Time.deltaTime * moveSpeed * Input.GetAxis("Vertical"));

        // Our player movement input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // This fixes diagonal movement
        moveInput.Normalize();

        // This moves the player
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
