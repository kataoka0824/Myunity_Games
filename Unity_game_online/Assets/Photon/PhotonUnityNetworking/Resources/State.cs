using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class State : MonoBehaviourPunCallbacks
{
    public int hp;
    public int trap1_re;
    public int block_re;
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp>100)
        {
            hp = 100;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "trap1_box")
        {
            trap1_re += 1;
            PhotonNetwork.Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "block_box")
        {
            block_re += 3;
            PhotonNetwork.Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "HP_box")
        {
            hp += 10;
            PhotonNetwork.Destroy(collision.gameObject);
        }
    }
}
