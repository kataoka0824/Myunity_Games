using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Put_block : MonoBehaviourPunCallbacks
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
        if (state_script.block_re > 0)
        {
            GameObject block1 = PhotonNetwork.Instantiate("block",
                                       player.transform.position +
                                       Vector3.up * 30f,
                                       Quaternion.identity);
            state_script.block_re -= 1;
        }
    }
}
