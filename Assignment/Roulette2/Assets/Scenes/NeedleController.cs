using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
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
            this.rotSpeed = -10;
        }
        else
        {
            this.rotSpeed *= 0.98f;
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
