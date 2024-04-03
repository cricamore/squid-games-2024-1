using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedManCircle : MonoBehaviour
{
    public Transform RedManCircleTransform;
    public Light SpotLight;
    private float speed = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        if(SpotLight != null){
            SpotLight.transform.position = RedManCircleTransform.position + Vector3.up * 2;
            SpotLight.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = RedManCircleTransform.position;

        position.x -= Mathf.Cos(Time.time) * Time.deltaTime * speed * 2;
        position.z += Mathf.Sin(Time.time) * Time.deltaTime * speed * 2;

        RedManCircleTransform.position = position;

    }
}
