using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Initiated_Restart : MonoBehaviour
{

    public void RestartGame()
    {
        // loads current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}