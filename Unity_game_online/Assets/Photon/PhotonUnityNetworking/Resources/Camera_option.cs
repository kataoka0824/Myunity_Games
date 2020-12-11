using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Camera_option : MonoBehaviourPunCallbacks
{
    public GameObject camera1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            camera1.SetActive(true);
        }
        else
        {
            camera1.SetActive(false);
        }
    }
}
