using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().position += pos_up_down;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Transform>().position -= pos_up_down;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += pos_right_left;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           GetComponent<Transform>().position -= pos_right_left;
        }
    }
}
