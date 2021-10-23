using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Damage_panel : MonoBehaviourPunCallbacks
{
    public GameObject panel;
    private float time1;
    private float time_lim;
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        time_lim = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf == true)
        {
            time1 += Time.deltaTime;
            
        }
        if (time1>time_lim && panel.activeSelf==true)
        {
            panel.SetActive(false);
        }
        
    }
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "weapon")
        {
            panel.SetActive(true);
            state_script.hp -= 10;
            time1 = 0;
        }
    }
}
