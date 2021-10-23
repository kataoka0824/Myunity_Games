using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Block_hp : MonoBehaviourPunCallbacks
{
    public GameObject block;
    public int block_hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (block_hp <= 0)
        {
            photonView.RequestOwnership();
            PhotonNetwork.Destroy(block);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "weapon")
        {
            block_hp -= 10;
        }
    }
    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            //データの送信
            stream.SendNext(block_hp);
        }
        else
        {
            //データの受信
            block_hp = (int)stream.ReceiveNext();
        }
    }
}
