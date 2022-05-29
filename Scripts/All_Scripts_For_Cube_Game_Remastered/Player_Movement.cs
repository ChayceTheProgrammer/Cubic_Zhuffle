using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // gives the script something to reference inside Unity
    public Rigidbody rb;

    public Transform Player_Position;

        // the 'f' signifies that we are talking about a float and not an integers
    public float forwardForce = 0f;

    public float rightForce = 0f;

    public float leftForce = 0f;

    public float VelocityChange = 0f;   // allows for editing directly how much I want the velocity
                                        // in the direction of left and right movement to change
    public float fallForce = 0f;

    public float slowForce = 0f;

    public float floatForce = 0f;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Testing In Progress!");
    }

    // Update is called once per frame
    void Update()
    {
        // UnityEngine.Debug.Log("Nothing Interesting This Frame!");
    }

    void FixedUpdate(){
        // Fixed update works with the Unity Physics Better than regualar "Update" Function
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
                            // Time.deltaTime accounts for the differences in FPS on a machine
        
        if(Input.GetKey("d")) {
            // checks input on keyboard for 'd' key and moves cube on x-axis (right-movement)
            rb.AddForce(rightForce, 0, 0 /*, ForceMode.VelocityChange*/);
        }

        if(Input.GetKey("a")) {
            // checks input on keyboard for 'a' key and moves cube on x-axis (left-movement)
            rb.AddForce(-1 * leftForce, 0, 0 /*, ForceMode.VelocityChange*/);
        }

        if(Input.GetKey("w"))
        {   // checks input on keyboard for 'w' and allows player to jump
            FindObjectOfType<Jumping_Script>().Jump();

        }

        if (Input.GetKey("m"))
        {   // broken button prompt when player can fly
            rb.AddForce(0, floatForce * Time.deltaTime, 0);
        }

        if (Input.GetKey("s"))
        {   // basic fall/slow functionality tied to 's' key
            if(Player_Position.position.y == 0.5)
            {
                rb.AddForce(0, 0, -1*slowForce * Time.deltaTime, ForceMode.VelocityChange);
            }

            if(Player_Position.position.y != 0.5)
            {
                rb.AddForce(0, -1*fallForce * Time.deltaTime, 0);
            }
        }
    }
}
