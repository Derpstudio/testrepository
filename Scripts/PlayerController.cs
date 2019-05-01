using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum type {platformer, topDown};
    public type moveType;
    public float moveSpeed, jumpHeight;
    bool onGround = false;
    public Rigidbody2D PlayerRB;
    float yvelocity;

    //debug

        

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {

        //Debug.Log(transform.position.x);
        //Debug.Log(transform.position.y);


        yvelocity = PlayerRB.velocity.y;

            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            

       

        //jumping

        if (moveType == type.platformer && Input.GetButton("Jump") && onGround)
        {
            PlayerRB.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

        //crounching and down

       // if (moveType == type.platformer && Input.GetAxisRaw("Vertical") < 0 && !onGround  && yvelocity > -35)
      //  {
     //       GetComponent<Rigidbody2D>().AddForce(Vector2.down * jumpHeight, ForceMode2D.Impulse);
      //  }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "ground")
        {
            onGround = false; 
        }
    }


}