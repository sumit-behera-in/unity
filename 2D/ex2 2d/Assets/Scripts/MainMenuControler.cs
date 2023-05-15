using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControler : MonoBehaviour
{
   public void play()
    {
        SceneManager.LoadScene("game");
    }
    public void exit()
    {
        Application.Quit();
    }
}
