using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private GameObject Player;
    private float HorizontalInput;
    private float Speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //HorizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * HorizontalInput * Speed * Time.deltaTime);
    }
}
