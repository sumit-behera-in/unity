using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer re;
    [SerializeField]
    private float speed;
    private void Awake()
    {
        re = GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        re.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
