using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    // Movement
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float moveVelocity;
    [SerializeField] private Animator animator;
    bool isGrounded;

    void Update () 
    {


        // Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
        {
            if(isGrounded)
            {
                GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;
        // Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("isWalking",true);
        }


        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("isWalking",true);
        }

        if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.D)) 
        {
            animator.SetBool("isWalking",false);
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
        //animator.SetBool("isWalking",false);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log ("Is Grounded = " + isGrounded);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
            Debug.Log ("Is Grounded = " + isGrounded);
        }
    }
}
