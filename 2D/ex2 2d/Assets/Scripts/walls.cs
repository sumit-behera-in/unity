using UnityEngine;
using UnityEngine.SceneManagement;

public class walls : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Front");
        }
    }
}
