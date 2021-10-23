using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_light_1p : MonoBehaviour
{
    public GameObject castle_light;
    Light lt;
    GameObject p1_obj;
    State_1p p1_script;
    // Start is called before the first frame update
    void Start()
    {
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
        lt = castle_light.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lt.intensity = p1_script.trap_light_power;
    }
}
