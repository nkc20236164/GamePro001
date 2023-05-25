using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.05f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.05f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }


    }
}
