using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
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
            // 시계 반대 방향
            this.rotSpeed = 20;
        }
        else
        {
            this.rotSpeed *= 0.98f;
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
