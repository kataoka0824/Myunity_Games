using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject bomb;
    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        rb= this.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up * 20.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "weapon")
        {
            Destroy(bomb);
            GameObject instance = (GameObject)Instantiate(explode,
                                   bomb.transform.position,
                                   Quaternion.identity);
        }
    }
    void OnDestroy()
    {
        
    }

}
