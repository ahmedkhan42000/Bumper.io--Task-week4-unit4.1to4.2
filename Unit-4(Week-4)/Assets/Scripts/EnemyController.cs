using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject Player;
    private GameObject Enemy;
    private Rigidbody RbEnemy;

    private float Boundry = 10;

    private float Speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        RbEnemy = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        RbEnemy.AddForce((Player.transform.position - transform.position).normalized * Speed * Time.deltaTime, ForceMode.Impulse);
    }
}
