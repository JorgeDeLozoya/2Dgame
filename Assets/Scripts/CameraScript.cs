using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    public Transform Cupra;


    // Update is called once per frame
    void Update()
    {
        if (Cupra !=null)
        {
            Vector3 position = transform.position;
            position.x = Cupra.transform.position.x;
            transform.position = position;
        }
    }
}
