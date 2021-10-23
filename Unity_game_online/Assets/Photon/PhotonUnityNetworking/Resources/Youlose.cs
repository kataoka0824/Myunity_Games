using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class Youlose : MonoBehaviourPunCallbacks
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.IsMine)
        {
            return;
        }
        if (state_script.hp <= 0)
        {
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("Youlose");
            
        }
    }
}
