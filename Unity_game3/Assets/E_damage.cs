using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_damage : MonoBehaviour
{
    public GameObject explode;
    public GameObject explode2;
    public E_state e_state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "explode")
        {
            e_state_script.e_hp -= 5;
        }
        if (collider.gameObject.tag == "explode2")
        {
            e_state_script.e_hp -= 10;
        }
        if (collider.gameObject.tag == "explode3")
        {
            //e_state_script.e_hp -= 3;
        }
        if (collider.gameObject.tag == "explode4")
        {
            e_state_script.e_hp -= 2;
        }
    }
}
