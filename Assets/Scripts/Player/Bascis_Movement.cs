using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bascis_Movement : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    private bool isGrounded;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpHeight;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        SideMovement();
        Jumping();
    }

    private void SideMovement()
    {
        if(Input.GetKey(KeyCode.A)) 
        {
            mySpriteRenderer.flipX = true;
            myAnimator.SetBool("IsWalking", true);
            transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            mySpriteRenderer.flipX = false;
            myAnimator.SetBool("IsWalking", true);
            transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }
        else
        {
            myAnimator.SetBool("IsWalking", false);
        }
    }

    private void Jumping()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true) 
        {
            myRigidbody2D.AddForce(transform.up * jumpHeight);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
