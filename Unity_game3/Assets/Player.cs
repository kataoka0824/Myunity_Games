using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 40.0f * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * 40.0f * Time.deltaTime;
        }
        if (Input.GetKey("right")) {
            transform.Rotate(0.0f, 2.0f, 0.0f);
        }
        if (Input.GetKey("left")) {
            transform.Rotate(0.0f, -2.0f, 0.0f);
        }
        Vector3 pos = this.gameObject.transform.position;
        if (pos.x < -1000f)
        {
            pos.x = -1000f;
        }
        if (pos.x > 1000f)
        {
            pos.x = 1000f;
        }
        if (pos.z < -1000f)
        {
            pos.z = -1000f;
        }
        if (pos.z > 1000f)
        {
            pos.z = 1000f;
        }
        if (pos.y < -2f)
        {
            pos.y = -2f;
        }
        this.gameObject.transform.position = pos;
    }
    void OnTriggerStay(Collider collider)
    {
        
        if (collider.gameObject.tag == "wall")
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(Vector3.up * 40f, ForceMode.Impulse);
            }
        }
    }
}
