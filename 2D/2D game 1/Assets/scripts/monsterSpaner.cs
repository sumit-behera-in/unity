using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterSpaner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;
    private GameObject spawnedMonster;
    private int randomIndex;
    private int randomSide;
    [SerializeField]
    private Transform LeftPos, RightPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spanMonsters());
    }

    IEnumerator spanMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, monsterReference.Length);
            //random monster
            randomSide = Random.Range(0, 2);
            //random side
            spawnedMonster = Instantiate(monsterReference[randomIndex]);
            //monster span
            if (randomSide == 0)
            {
                //left side
                spawnedMonster.transform.position = LeftPos.position;
                spawnedMonster.GetComponent<monsters>().speed = Random.Range(1, 5);
                //monster script access
            }
            else
            {
                //right side
                spawnedMonster.transform.position = RightPos.position;
                spawnedMonster.transform.localScale = new Vector3(-2f, 2f, 1f);
                spawnedMonster.GetComponent<monsters>().speed = -Random.Range(1,5);
                

                //monster script access
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
