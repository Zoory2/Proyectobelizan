using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontrol : MonoBehaviour
{

    public Camera cam;
    
    
    void Update()
    {
        Vector3 camPos = cam.transform.position;
        camPos.x = transform.position.x;
        camPos.y = transform.position.y;
        cam.transform.position = camPos;




    }
}
