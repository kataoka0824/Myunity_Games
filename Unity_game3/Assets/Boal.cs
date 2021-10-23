using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boal : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject boal;
    public GameObject explode2;
    public GameObject player;
    public int jud = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        boal.transform.LookAt(player.transform.position);
        //rb.AddForce(Vector3.forward * 10.0f);
        boal.transform.Translate(Vector3.forward * 2.0f);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "weapon" || collision.gameObject.tag == "Enemy")
        {
            
            GameObject instance = (GameObject)Instantiate(explode2,
                                   boal.transform.position,
                                   Quaternion.identity);
            boal.SetActive(false);
        }
    }
}
