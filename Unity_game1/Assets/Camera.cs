using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(20.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0.0f, 10.0f, - 20.0f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.RotateAround(ball.transform.position, Vector3.up, 1.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.RotateAround(ball.transform.position, Vector3.up, -1.0f);
        }
    }
}
