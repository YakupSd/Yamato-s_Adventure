using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Jumpspeed;
    private Animator animasyon;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private BoxCollider2D boxCollider;
    private float wallJumpCooldown;
    private float HorizontalInput;


    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animasyon = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");



        //ters dönme hareketi
        if (HorizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(7, 7, 7); ;
        }
        else if (HorizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-7, 7, 7);
        }



        //animasyon parametresi
        animasyon.SetBool("run", HorizontalInput != 0);
        animasyon.SetBool("grounded", isGrounded());

        if (wallJumpCooldown < 0.2F)// DUVAR ZIPLAMASI
        {

            body.velocity = new Vector2(HorizontalInput * speed, body.velocity.y);
            if (onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;

            }
            else
            {
                body.gravityScale = 3;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();

            }
        }
        else
        {
            wallJumpCooldown += Time.deltaTime;
        }


    }
    private void WallJump()
    {
         if (onWall() && !isGrounded())
        {
            if (HorizontalInput == 0)
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
            {

                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
            }
            wallJumpCooldown = 0;
        }


        animasyon.SetTrigger("WallJump");
        
    }
    private void Jump()
    {
        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, Jumpspeed);
            animasyon.SetTrigger("jump");
        }
        else if (onWall() && !isGrounded())
        {
            if (HorizontalInput == 0)
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                animasyon.SetTrigger("WallJump");
            }
            else
            {
               
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
            }
            wallJumpCooldown = 0;
        }




    }
    //private void WallJump()
    //{
    //    if (isGrounded())
    //    {
    //        body.velocity = new Vector2(body.velocity.x, Jumpspeed);
    //        animasyon.SetTrigger("WallJump");
    //    }
    //    else if (onWall() && !isGrounded())
    //    {
    //        if (HorizontalInput == 0)
    //        {
    //            body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
    //            transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    //        }
    //        else
    //        {

    //            body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
    //        }
    //        wallJumpCooldown = 0;
    //    }




    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }

    public bool canAttack()
    {
        return HorizontalInput == 0 && isGrounded() && !onWall();

    }
}
