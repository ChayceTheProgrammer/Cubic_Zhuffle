using UnityEngine;

public class EndTrigger_Script : MonoBehaviour
{
    public GameManager_Script GameManagerReference;
    public void OnTriggerEnter(Collider other)
    {
        GameManagerReference.CompleteLevel();
    }

}
