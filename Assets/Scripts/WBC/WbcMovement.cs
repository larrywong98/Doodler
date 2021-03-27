﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public class WbcMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    private float moveSpeed;
    public Animator animator;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed=FullControl.mainCharacterMoveSpeed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(VJoystick.joystickpos.x != 0 || VJoystick.joystickpos.y!=0 ){
            moveH = VJoystick.joystickpos.x* moveSpeed;
            moveV = VJoystick.joystickpos.y* moveSpeed;
        }else{
            moveH = Input.GetAxis("Horizontal") * moveSpeed;
            moveV = Input.GetAxis("Vertical") * moveSpeed;
        }
        

        Vector3 movement = new Vector3 (moveH, moveV, 0f);
        // Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"),Input.GetAxis("Vertical") , -1f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("AttackDirection", VAim.attackDirection.x);
        animator.SetFloat("Magnitude", movement.magnitude);
        // Flip();
        rb.velocity = new Vector2(moveH, moveV);

        // IDLE时若有attackdirection则转向并清零
        if(movement.x == moveSpeed || movement.x == -moveSpeed){

            animator.SetFloat("LastMoveX", movement.x);
        }
        
    }


 

}
