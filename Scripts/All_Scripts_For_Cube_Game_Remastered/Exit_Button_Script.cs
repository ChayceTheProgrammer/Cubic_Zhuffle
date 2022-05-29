using UnityEngine;

public class Exit_Button_Script : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("PLAYER HAS QUIT!");
        Application.Quit();
    }
}
