using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    private Vector3 tempPos;
    private float max=23f, min=-26f;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform ;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;
        tempPos = transform.position;
        tempPos.x = player.position.x;
        if (tempPos.x >= max) { tempPos.x = max; }
        if (tempPos.x <=min ) { tempPos.x = min; }
        transform.position = tempPos;

    }
}
