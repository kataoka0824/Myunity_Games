using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Block_make : MonoBehaviourPunCallbacks
{
    public Vector3 v1;
    public int block_re;
    public int jud = 0;
    public Make_room room_script;
    //public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (room_script.master == true && jud==0)
        {
            for (int i = 0; i < block_re; i++)
            {
                v1 = new Vector3(Random.Range(0f, 1000f), 10f, Random.Range(0f, 1000f));
                GameObject instance = PhotonNetwork.Instantiate("block", v1, Quaternion.identity);
            }
            jud = 1;
        }
    }
}
