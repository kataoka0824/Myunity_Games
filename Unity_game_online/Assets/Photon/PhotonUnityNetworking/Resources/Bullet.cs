using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Bullet : MonoBehaviourPunCallbacks
{
    public GameObject bullet;
    public Block_hp block_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "floar" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "weapon")
        {
            PhotonNetwork.Destroy(bullet);
        }
    }*/
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "wall" || collider.gameObject.tag == "floar" || collider.gameObject.tag == "weapon")
        {
            PhotonNetwork.Destroy(bullet);
        }
        if(collider.gameObject.tag == "block")
        {
            PhotonNetwork.Destroy(bullet);
        }
    }
}
