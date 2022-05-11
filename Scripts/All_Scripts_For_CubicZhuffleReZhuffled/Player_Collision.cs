using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Player_Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo){
        // UnityEngine.Debug.Log("We Hit Something!");

        if (collisionInfo.collider.tag == "Obstacle"){
            UnityEngine.Debug.Log("You Hit an Obstacle");
            movement.enabled = false; // disables player movement script once you hit an obstacle by disabling the script for movement
        }

    }

}
