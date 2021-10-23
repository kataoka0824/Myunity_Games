using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Put_trap : MonoBehaviourPunCallbacks
{
    public State state_script;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton()
    {
        if (state_script.trap1_re > 0)
        {
            GameObject trap1 = PhotonNetwork.Instantiate("trap1",
                                       player.transform.position+
                                       Vector3.up*20f,
                                       Quaternion.identity);
            state_script.trap1_re -= 1;
        }
    }
}
