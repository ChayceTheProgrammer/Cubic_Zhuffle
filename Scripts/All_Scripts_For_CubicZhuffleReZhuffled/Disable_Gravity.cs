using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Gravity : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Gravity Disabled!");
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
