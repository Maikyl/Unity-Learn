using UnityEngine;

public class SolarControl : MonoBehaviour
{
    private GameObject _lightObject;
    private GameObject _lightObject2;
    private Light _lightSource;
    private Light _lightSource2;

    private float xAxis = 17.9f;
    private float yAxis = 0f;
    private float zAxis = 0f;
    private float xAxis2 = 15.8f;
    private float yAxis2 = -6f;
    private float zAxis2 = 0f;

    private float plus = 0.1f;
    private float plus2 = 0.1f;

    void Start()
    {
        _lightObject = new GameObject();
        _lightSource = _lightObject.AddComponent<Light>();
        _lightObject.name = "Sol";
        _lightSource.type = LightType.Directional;
        _lightSource = RenderSettings.sun;

        _lightObject2 = new GameObject();
        _lightSource2 = _lightObject2.AddComponent<Light>();
        _lightObject2.name = "Sol 2";
        _lightSource2.type = LightType.Directional;
        _lightSource2 = RenderSettings.sun;
    }

    void Update()
    {
        //if (xAxis >= 17.9f)
        //    plus *= -1;

        //if (xAxis <= -72.1f)
        //    plus *= -1;

        //_lightObject.transform.rotation = Quaternion.Euler(xAxis += plus, yAxis += 0.1f, zAxis);

        //if (xAxis2 >= 17.9f)
        //    plus2 *= -1;

        //if (xAxis2 <= -72.1)
        //    plus2 *= -1;

        //_lightObject2.transform.rotation = Quaternion.Euler(xAxis2 += plus2, yAxis2 += 0.1f, zAxis2);

        //Debug.Log(xAxis2);


    }
}