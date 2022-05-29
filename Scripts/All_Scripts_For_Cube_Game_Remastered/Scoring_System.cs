using UnityEngine;
using TMPro;

public class Scoring_System : MonoBehaviour
{
    public Transform Player_Position;
    public TMP_Text Score_Text;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        Score_Text.text = Player_Position.position.z.ToString("0");
        
    }
}
