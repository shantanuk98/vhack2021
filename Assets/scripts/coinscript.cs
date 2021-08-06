using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    float t = 0;
    float xp = 0, yp = 0, zp = 0;
    // Start is called before the first frame update
    void Start()
    {
        xp = transform.position.x;
        yp = transform.position.y;
        zp = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xp, yp+Mathf.Sin(t)*0.5f, zp);
        transform.Rotate(new Vector3(1f,0, 0f)); 
        t += 0.01f;
    }
}
