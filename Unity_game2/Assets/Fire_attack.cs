using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_attack : MonoBehaviour
{
    //public Action action_script;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.LookAt(action_script.hit_pos);
        //rb.velocity = transform.forward * 10f;
        transform.Translate(0f, 0f, 1f);*/
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 15000 * Time.fixedDeltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
