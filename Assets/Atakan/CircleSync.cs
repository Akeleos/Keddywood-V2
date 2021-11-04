using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSync : MonoBehaviour
{
    public Material WallMaterial;
    public Camera camview;
    public LayerMask Mask;
    public static int PosID = Shader.PropertyToID("_PlayerPosition");
    public static int SizeID = Shader.PropertyToID("_Size");
    void Update()
    {
        var dir = camview.transform.position - transform.position;
        var ray = new Ray(transform.position, dir.normalized);
        if(Physics.Raycast(ray,3000,Mask))
            WallMaterial.SetFloat(SizeID,1);
        else 
            WallMaterial.SetFloat(SizeID,0);
        var view = camview.WorldToViewportPoint(transform.position + new Vector3(-80,-70,-5));
        WallMaterial.SetVector(PosID,view);
    }
}
