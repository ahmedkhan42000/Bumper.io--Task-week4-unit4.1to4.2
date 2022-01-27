using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;

    private float Boundry = 10;
    public int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Player, new Vector3(0, 1, 0), Enemy.transform.rotation);

        for (int i = 0; i < EnemyCount; i++)
        {
            spawnEnemies();
        }
        
    }

    public void spawnEnemies()
    {
        float BoundryX = Random.Range(-Boundry, Boundry);
        float BoundryZ = Random.Range(-Boundry, Boundry);
        Instantiate(Enemy, new Vector3(BoundryX, 0, BoundryZ), Enemy.transform.rotation);
    }

    // Update is called once per frame
     void Update()
    {
        //if (transform.position.y < 0)
        //{
        //    Destroy(Enemy);
        //    spawnEnemies();
        //}
    }
}
