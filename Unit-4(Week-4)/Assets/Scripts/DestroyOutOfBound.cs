using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public GameObject AfterCollision;
    private Material  material;

    private Transform PlayerTransform;
    private int Boundry = 10;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerTransform = GetComponent<Transform>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -2)
        {
            //spawnEnemies();

            Player.transform.localScale += new Vector3(1, 1, 1);
            Player.GetComponent<Rigidbody>().mass += 1;
            //Player.GetComponent<MeshRenderer>().materials
            Destroy(Enemy);
            Debug.Log("Size Increased");
            Debug.Log("Mass Increased");
        }

    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy"))
    //    {
    //        AfterCollision = collision.gameObject;
    //    } 
    //}
    public void spawnEnemies()
    {
        float BoundryX = Random.Range(-Boundry, Boundry);
        float BoundryZ = Random.Range(-Boundry, Boundry);
        Instantiate(Enemy, new Vector3(BoundryX, 0, BoundryZ), Enemy.transform.rotation);
        Instantiate(Enemy, new Vector3(BoundryX, 0, BoundryZ), gameObject.transform.rotation);
        //float BoundryX2 = Random.Range(-Boundry, Boundry);
        //float BoundryZ2 = Random.Range(-Boundry, Boundry);
        //Instantiate(gameObject, new Vector3(BoundryX2, 0, BoundryZ2), gameObject.transform.rotation);

    }
}
