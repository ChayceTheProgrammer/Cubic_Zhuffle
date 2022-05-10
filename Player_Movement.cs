using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // gives the script something to reference inside Unity
    public Rigidbody rb;

        // the 'f' signifies that we are talking about a float and not an integer.s
    public float forwardForce = 0f;

    public float rightForce = 0f;

    public float leftForce = 0f;

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
                            //Time.deltaTime accounts for the differences in fps on a machine
        
        if(Input.GetKey("d")) {
            // checks input on keyboard for 'd' key and moves cube on x-axis (right-movement)
            rb.AddForce(rightForce, 0, 0);
        }

        if(Input.GetKey("a")) {
            // checks input on keyboard for 'a' key and moves cube on x-axis (left-movement)
            rb.AddForce(-1 * leftForce, 0, 0);
        }

    }
}
