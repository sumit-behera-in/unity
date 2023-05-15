using UnityEngine;

public class monsters : MonoBehaviour
{
    [HideInInspector]
    public float speed ;
    private Rigidbody2D mybody;
    private Rigidbody2D p = player.mybody;
    public float Speed { get => speed; set => speed = value; }

    // Start is called before the first frame update
    void Start() { 
   
        mybody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        mybody.velocity = new Vector2(speed, mybody.velocity.y);
        if (mybody.position.x == p.position.x)
        {
            scoreScript.scoreValue+=10;
        }
    }
    
}
