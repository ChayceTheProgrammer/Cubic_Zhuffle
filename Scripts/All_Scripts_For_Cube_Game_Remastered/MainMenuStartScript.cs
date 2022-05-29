using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuStartScript : MonoBehaviour
{
    public void Start_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
