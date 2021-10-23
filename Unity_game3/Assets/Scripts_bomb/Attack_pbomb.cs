﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_pbomb : MonoBehaviour
{
    public GameObject player;
    public GameObject pbomb;
    public Rigidbody rb;
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && state_script.mode==1 
            && state_script.pbomb_re>0)
        {
            GameObject instance = (GameObject)Instantiate(pbomb,
                               player.transform.position + player.transform.forward * 10.0f,
                               Quaternion.Euler(0, player.transform.rotation.eulerAngles.y, 0));
            rb = instance.GetComponent<Rigidbody>();
           //Debug.Log(player.transform.rotation.eulerAngles);
            rb.AddForce(transform.forward * 60.0f, ForceMode.Impulse);
            state_script.pbomb_re -= 1;
        }
    }
}
