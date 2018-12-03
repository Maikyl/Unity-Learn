using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunarControl : MonoBehaviour
{
    private GameObject _moonObject;
    private GameObject _rotationObject;
    private float xAxis = -72.2f;
    private float yAxis = 180;
    private float zAxis = 0;
    private float plus = 0.1f;
    
    void Start()
    {
        _moonObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _moonObject.name = "Luna";
        
        _rotationObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _rotationObject.name = "Lunar Rotation";
        _moonObject.transform.SetParent(_rotationObject.transform);
        _moonObject.transform.position = new Vector3(100, 0, 0);
        _moonObject.transform.localScale = new Vector3(10, 10, 10);
    }
    
    void Update()
    {
        _rotationObject.transform.rotation = Quaternion.Euler(xAxis += plus, yAxis += 0.1f, zAxis);

        if (xAxis >= 17.8f)
        {
            plus *= -1;
        }
        
        if (xAxis <= -72.2f)
        {
            plus *= -1;
        }
    }
}