using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed;
    float horizontalMovement = 0f;
    bool jump = false;
    bool crouch = false;

    // Update to check if we hit these buttons
    public void Update()
    {
        // Get input 
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Check if we Jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
