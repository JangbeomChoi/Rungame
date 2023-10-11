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
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * startJumpPower, ForceMode2D.Impulse);
            
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(!isGround) 
        {
            ChangeAnim(State.Run);
        }
        
        isGround = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        ChangeAnim(State.Jump);
        isGround = false;
    }
    void ChangeAnim(State state)
    {
        anim.SetInteger("State", (int)state);
    }
}
