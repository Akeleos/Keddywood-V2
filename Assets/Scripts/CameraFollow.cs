using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    public Vector3 targetOffset;
    public float smoothSpeed = 2f;

    private void FixedUpdate()
    {
        Vector3 desiredPos = followTarget.position + targetOffset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;
        transform.LookAt(followTarget);
    }
}
    

