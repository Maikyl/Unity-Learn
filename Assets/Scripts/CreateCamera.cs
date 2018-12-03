using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCamera : MonoBehaviour
{
    private GameObject _cameraObject;
    void Start()
    {
        _cameraObject = new GameObject();
        _cameraObject.AddComponent<Camera>();
        _cameraObject.name = "Camera";
    }
}