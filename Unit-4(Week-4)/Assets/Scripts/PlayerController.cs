using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody RbPlayer;
    private GameObject FocalPoint;

    private float Speed = 4;
    public float HorizontalInput;
    public float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        RbPlayer = GetComponent<Rigidbody>();
        FocalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput   = Input.GetAxis("Vertical");
        RbPlayer.AddForce(FocalPoint.transform.forward * VerticalInput * Time.deltaTime * Speed, ForceMode.Impulse);
        RbPlayer.AddForce(FocalPoint.transform.right * HorizontalInput * Time.deltaTime * Speed, ForceMode.Impulse);

    }
}
