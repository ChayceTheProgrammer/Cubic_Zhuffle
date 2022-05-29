using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Player_Movement movement;
    public Rigidbody rb;
    public float upForce = 0f;
    public float jumpPadForce = 0f;
    public  bool HitObstacle;

    public void OnCollisionEnter(Collision collisionInfo){
        // UnityEngine.Debug.Log("We Hit Something!");
        

        if (collisionInfo.collider.tag == "Obstacle"){
            Debug.Log("You Hit an Obstacle");
            movement.enabled = false; // disables player movement script once you hit an obstacle by disabling the script for movement
            rb.AddForce(0, upForce * Time.deltaTime, 0); // adds a tiny force in the y-direction to start the showing of the disabled gravity effect
            rb.useGravity = false; // disables gravity of the player
            HitObstacle = true;
        } 
        else if (collisionInfo.collider.tag == "JumPad")
        {
            rb.AddForce(0, jumpPadForce * Time.deltaTime, 0);

        }
        

    }

}
