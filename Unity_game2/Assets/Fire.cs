using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject fire_obj;
    //private GameObject fire_objs;
    public GameObject player;
    public Action action_script;
    public int fire_mode = 0;
    private Rigidbody rb;
    private Vector3 hit_pos;
    public float speed=1000f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = fire_obj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            //Debug.Log(hit.point);
            hit_pos = hit.point;
            GameObject fire_objs = Instantiate(fire_obj,player.transform.position,Quaternion.Euler(hit_pos)) as GameObject;
            fire_objs.transform.LookAt(hit_pos);
            //rb=fire_objs.GetComponent<Rigidbody>();
            //rb.AddForce(transform.forward*speed);
        }
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(fire_objs);
        }
    }*/
}
