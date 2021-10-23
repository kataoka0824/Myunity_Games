using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_light_2p : MonoBehaviour
{
    public GameObject bomb_light;
    Light lt;
    GameObject p2_obj;
    State_2p p2_script;
    // Start is called before the first frame update
    void Start()
    {
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
        lt = bomb_light.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lt.intensity = p2_script.bomb_light_power;
    }
}
