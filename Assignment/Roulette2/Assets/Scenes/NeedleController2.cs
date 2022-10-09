using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController2 : MonoBehaviour
{
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = -4 / 9f;
        }
        else
        {
            this.rotSpeed *= 0.995f;
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
