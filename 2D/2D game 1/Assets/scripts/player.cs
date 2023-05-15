using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 15f;
    private float movementX;
    public static Rigidbody2D mybody;
    private Animator anim;
    private string WALK_ANIMATION="walk";
    private SpriteRenderer sr;
    private bool isGrounded;
    private string colbase = "road";
    private string enemy = "enemy";
    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovedKeybord();
        animatePlayer();
        playerJump();
    }
    //private void FixedUpdate()
    //{
    //    playerJump();
    //}
    void playerMovedKeybord()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }
    void animatePlayer()
    {
        if(movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
    void playerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            mybody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(colbase))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag(enemy))
        {
            SceneManager.LoadScene("front");
        }
    }
}
