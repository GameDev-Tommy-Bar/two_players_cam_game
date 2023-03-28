using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    Vector3 pos_up_down;
    Vector3 pos_right_left;
    // Start is called before the first frame update
    void Start()
    {
            pos_up_down = new Vector3(0,0.01f,0);
            pos_right_left = new Vector3(0.01f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += pos_up_down;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position -= pos_up_down;

        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += pos_right_left;
        }

        if (Input.GetKey(KeyCode.A))
        {
           GetComponent<Transform>().position -= pos_right_left;
        }
    }
}
