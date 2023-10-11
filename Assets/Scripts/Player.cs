using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum State 
    {
        Stand,
        Run,
        Jump,
        Hit,
    }
    public float startJumpPower;
    public float jumpPower;
    public bool isGround;
    private bool isJumpKey;
    Rigidbody2D rb;
    Animator anim;
    

    void Awake()
    {
        //√ ±‚»≠
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);            
        }

        isJumpKey = Input.GetButton("Jump");
       
    }
    void FixedUpdate()
    {
        if (isJumpKey && !isGround)
        {
            jumpPower = Mathf.Lerp(jumpPower, 0, 0.1f);
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(!isGround) 
        {
            ChangeAnim(State.Run);
            jumpPower = 1;
        }
        
        isGround = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        ChangeAnim(State.Jump);
        isGround = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        rb.simulated = false;
        ChangeAnim(State.Hit);

    }
    void ChangeAnim(State state)
    {
        anim.SetInteger("State", (int)state);
    }
}

