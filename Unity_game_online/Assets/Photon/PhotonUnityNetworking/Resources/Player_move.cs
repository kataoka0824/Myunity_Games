using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player_move : MonoBehaviourPunCallbacks
{
    private Rigidbody rb;
    public GameObject player;
    private float rot_x;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            Vector3 pos = player.transform.position;
        
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.Translate(0.8f, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.Translate(-0.8f, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                transform.Translate(0.0f, 0.0f, 0.8f);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                transform.Translate(0.0f, 0.0f, -0.8f);
            }
            if (pos.x < 0)
            {
                pos.x = 0;
            }
            if (pos.x > 1000)
            {
                pos.x = 1000;
            }
            if (pos.z < 0)
            {
                pos.z = 0;
            }
            if (pos.z > 1000)
            {
                pos.z = 1000;
            }
        
            if (Input.GetMouseButton(0))
            {
                //Debug.Log(Input.GetAxis("Mouse X"));
                rot_x = Input.GetAxis("Mouse X");
                player.transform.Rotate(0.0f, -rot_x * 2, 0.0f);
            }  
        }
        
        //this.gameObject.transform.position = pos;
    }
    void OnTriggerStay(Collider collider)
    {
        if (photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space) && collider.gameObject.tag=="floar")
            {
                rb.AddForce(Vector3.up*60.0f, ForceMode.Impulse);
            }
        }
        
    }
}
