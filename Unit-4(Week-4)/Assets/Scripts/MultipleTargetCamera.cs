using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCamera : MonoBehaviour
{

    public List<Transform> Targets;
    public Vector3 Offset;
    private Vector3 velocity;

    public float SmoothTime = .05f;
    public float MinZoom = 10f;
    public float MaXZoom = 40f;
    public float ZoomLimiter = 50f;

    private Camera Cam;

    void Start()
    {
        Cam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        if (Targets.Count == 0)
        {return;}

        Move();
        Zoom();
    }

    private void Zoom()
    {
        //Debug.Log(GetGreatestDistance());
        float NewZoom = Mathf.Lerp(MaXZoom, MinZoom, GetGreatestDistance() / ZoomLimiter);
        Cam.fieldOfView = Mathf.Lerp(Cam.fieldOfView, NewZoom, Time.deltaTime);
    }
    float GetGreatestDistance()
    {
        var bounds = new Bounds(Targets[0].position, Vector3.zero);
        for (int i = 0; i < Targets.Count; i++)
        {
            bounds.Encapsulate(Targets[i].position);
        }

        return bounds.size.x;
    }
    private Vector3 Move()
    {
        Vector3 CenterPoint = GetCenterPoint();
        Vector3 NewPosition = CenterPoint + Offset;
        transform.position = Vector3.SmoothDamp(transform.position, NewPosition, ref velocity, SmoothTime);
        return NewPosition;
    }
    private Vector3 GetCenterPoint()
    {
        if (Targets.Count == 1)
        {
            return Targets[0].position;
        }
        var bounds = new Bounds(Targets[0].position, Vector3.zero);
        for (int i = 0; i < Targets.Count; i++)
        {
            bounds.Encapsulate(Targets[i].position);
        }

        return bounds.center;
    }


    void Update()
    {
        
    }
}
