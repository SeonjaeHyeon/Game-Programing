using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    GameObject car;
    bool isRotated = false;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
    }

    // Update is called once per frame
    void Update()
    {
        float length = transform.position.x - this.car.transform.position.x;
        if (length <= 0 && !isRotated)
        {
            transform.Rotate(0, 0, -70);
            isRotated = true;
        }
    }
}
