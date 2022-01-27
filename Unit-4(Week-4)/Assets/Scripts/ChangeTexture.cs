using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    public Material[] ObjectMaterial;
    private Renderer Meshrender;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Meshrender = GetComponent<MeshRenderer>();
        Player = GameObject.Find("Player");
        //Player.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", m_MainTexture[position]);

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.localScale == new Vector3(2,2,2))
        {
            //Player.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", m_MainTexture[position]);
            Meshrender.material = ObjectMaterial[0];
        }
        if (Player.transform.localScale == new Vector3(3, 3, 3))
        {
            Meshrender.material = ObjectMaterial[1];
        }
        if (Player.transform.localScale == new Vector3(4, 4, 4))
        {
            Meshrender.material = ObjectMaterial[2];
        }
        if (Player.transform.localScale == new Vector3(5, 5, 5))
        {
            Meshrender.material = ObjectMaterial[3];
        }
       

    }
}
