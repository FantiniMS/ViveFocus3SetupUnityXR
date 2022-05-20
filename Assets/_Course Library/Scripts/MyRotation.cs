using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotation : MonoBehaviour
{
    public float rotSpeed;
    

    void Update()
    {
        transform.Rotate(transform.up, (rotSpeed) * Time.deltaTime,Space.World);
    }
}
