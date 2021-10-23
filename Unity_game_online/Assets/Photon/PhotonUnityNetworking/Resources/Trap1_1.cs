using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Trap1_1 : MonoBehaviourPunCallbacks
{
    public GameObject trap1;
    public int trap1_hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trap1_hp <= 0)
        {
            photonView.RequestOwnership();
            PhotonNetwork.Destroy(trap1);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "weapon")
        {
            trap1_hp -= 10;
        }
    }
    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            //データの送信
            stream.SendNext(trap1_hp);
        }
        else
        {
            //データの受信
            trap1_hp = (int)stream.ReceiveNext();
        }
    }
}
