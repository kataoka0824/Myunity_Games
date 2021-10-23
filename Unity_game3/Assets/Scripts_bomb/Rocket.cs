using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject rocket;
    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "weapon")
        {
            GameObject instance = (GameObject)Instantiate(explode,
                                   rocket.transform.position,
                                   Quaternion.identity);
            Destroy(rocket);
        }
    }
    void OnDestroy()
    {
        
    }
}
