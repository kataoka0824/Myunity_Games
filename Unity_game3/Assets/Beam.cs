using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject beam;
    public GameObject explode3;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.forward * 80.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "weapon" || collision.gameObject.tag == "Enemy")
        {
            GameObject instance = (GameObject)Instantiate(explode3,
                                   beam.transform.position,
                                   Quaternion.identity);
            Destroy(beam);
        }
    }
    void OnDestroy()
    {
        
    }
}
