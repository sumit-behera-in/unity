using UnityEngine;

public class destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {

            Destroy(collision.gameObject);
        }
    }
}
