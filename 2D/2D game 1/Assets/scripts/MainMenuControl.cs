using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    //button function
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }
    public void quit()
    {
        Application.Quit();
    }
}
