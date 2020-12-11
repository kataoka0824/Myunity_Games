using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Wait_room : MonoBehaviourPunCallbacks
{
    public Make_room room_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (room_script.player_re == 2)
        {
            photonView.RequestOwnership();
            PhotonNetwork.Destroy(this.gameObject);
        }
    }
}
