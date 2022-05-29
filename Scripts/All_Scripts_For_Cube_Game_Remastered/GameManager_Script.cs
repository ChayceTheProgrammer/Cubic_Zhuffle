using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Script : MonoBehaviour
{
    public float Death_Plane_Y_Value = 0f;

    public Rigidbody rb;

    bool Player_Lost = false;

    public float RestartDelaySeconds = 0f;

    public GameObject CompleteLevelUI;
    public Player_Movement movement;

    public void CompleteLevel() 
    {
        Debug.Log("Level Completed!");
        CompleteLevelUI.SetActive(true);
    }

    public void GameEnded() 
     /* making the method public allows for this method
        to be called by other scripts when this script is referenced*/
    {
        if(Player_Lost == false)
        {
            Debug.Log("Game Over");
            Player_Lost = true;
        }
        else // else branch when player lost but needs to press restart
        {
            Debug.Log("Player Already Lost, awaiting restart prompt");
            // Player_Lost = true;
        }
    }

    private void FixedUpdate()
    {
        if (rb.position.y <= Death_Plane_Y_Value)
        {
            GameEnded();
            // FindObjectOfType<GameManager_Script>().GameEnded(); Useful for referencing another script
            Invoke("Restart", RestartDelaySeconds);
            movement.enabled = false;


        }
        else if(FindObjectOfType<Player_Collision>().HitObstacle == true)
        {
            // FindObjectOfType<GameManager_Script>().GameEnded();
            GameEnded();
            Invoke("Restart", RestartDelaySeconds);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
