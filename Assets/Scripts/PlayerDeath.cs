using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    float deathY = -20f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < deathY)
        {
            Debug.Log("You have died");
            animator.SetBool("isJumping", false);
            animator.SetBool("isDead", true);
        }
    }
}
