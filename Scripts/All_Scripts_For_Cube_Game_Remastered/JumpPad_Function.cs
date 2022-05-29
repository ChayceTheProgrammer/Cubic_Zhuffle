using UnityEngine;

public class JumpPad_Function : MonoBehaviour
{
    public float Jumpad_Force = 0f;
    public Transform Player_Position;
    public Transform Jumpad_Position;
    public Rigidbody Player_rb;

    // Update is called once per frame
    void Update()
    {
       if(Player_Position.position.z == Jumpad_Position.position.z)
        {
            Debug.Log("Player touched a jumpad!");
            Player_rb.AddForce(0, Jumpad_Force * Time.deltaTime, 0);
        }
    }
}
