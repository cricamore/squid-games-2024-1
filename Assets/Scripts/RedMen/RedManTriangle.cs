using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedManTriangle : MonoBehaviour
{
    public Transform RedManTriangleTransform;
    private float speed = 2.0f;
    public Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = RedManTriangleTransform.position;
  
        if (position.x >= -2.0f && position.x < 2.0f && position.y == 0.0f)
        {
            position.x += Time.deltaTime * speed;
        }
        else if (position.x > 0.0f && position.y >= 0.0f)
        {
            position.x -= Time.deltaTime * speed;
            position.y += Time.deltaTime * speed;
        }
        else if (position.x > -2.0f && position.y >= 0.0f)
        {
            position.x -= Time.deltaTime * speed;
            position.y -= Time.deltaTime * speed;
        }
        else
        {
            position.x = -2.0f;
            position.y = 0.0f;
        }

        RedManTriangleTransform.position = position;

        // Posiciona la luz por encima del objeto RedManTriangle
        Vector3 lightPosition = RedManTriangleTransform.position;
        lightPosition.y += 2.0f; // Ajusta esta posición según tu necesidad
        pointLight.transform.position = lightPosition;
    }
}
