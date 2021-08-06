using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    int ctr;
    public float sensitivity;
    // Start is called before the first frame update
    void Start()
    {
        sensitivity = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = -1 * Input.GetAxis("Mouse Y");
        if(Input.GetMouseButton(0)) transform.Rotate(rotateVertical * sensitivity, rotateHorizontal * sensitivity,0f);
     

    }
}
