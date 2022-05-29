using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping_Script : MonoBehaviour
{
    public float JumpForce = 1f;
    public float JumpDelay = 1f;
    private bool CanJump;
    private bool IsJumping;
    public Rigidbody rb;
    private float Countdown;
    public float VelocityChange = 0f;

    // Start is called before the first frame update
    void Start()
    {
        CanJump = true;
        Countdown = JumpDelay;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsJumping && Countdown > 0)
        {
            Countdown -= Time.deltaTime;
        }
        else
        {
            CanJump = true;
            IsJumping = false;
            Countdown = JumpDelay;
        }
    }
    public void Jump()
    {
        if(CanJump == true)
        {
            if (Input.GetKey("w"))
            {
                CanJump = false;
                IsJumping = true;
                rb.AddForce(0, JumpForce, 0, ForceMode.VelocityChange);
            }

        }
    }
}
