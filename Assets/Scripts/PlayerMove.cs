using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb2D;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Player has pressed up");
        }

        if(Input.GetKey ("down"))
        {
            Debug.Log("Player has pressed down");
        }
    }
}
