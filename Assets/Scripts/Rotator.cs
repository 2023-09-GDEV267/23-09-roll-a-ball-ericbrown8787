using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    int x = 15;
    int y = 30;
    int z = 45;
    public Boolean disableX = false;
    public Boolean disableY = false;
    public Boolean disableZ = false;

    void Update()
    {   
        if (disableX)
        {
            x = 0;
        }
        else
        {
            x = 15;
        }
        if (disableY)
        {
            y = 0;
        }
        else
        {
            y = 30;
        }
        if (disableZ)
        {
            z = 0;
        }
        else
        {
            z = 45;
        }
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
    }
}
