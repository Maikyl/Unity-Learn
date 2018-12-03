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
        _moonObject.transform.localPosition = new Vector3(0, Mathf.Sin(Time.time * 2) * 25, 100);
        _rotationObject.transform.Rotate(new Vector3(0, 1, 0));
    }
}