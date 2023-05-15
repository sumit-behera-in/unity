using UnityEngine;

public class Jump : MonoBehaviour
{

    private float force=5;
    // Start is called before the first frame update
    private float g = -9.8f;
    private Vector3 v;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v = Vector3.up * force;
        }
        v.y += g * Time.deltaTime;
        transform.position += v * Time.deltaTime;
    }
   
}
