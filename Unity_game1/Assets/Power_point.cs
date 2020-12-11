using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power_point : MonoBehaviour
{
    public Sword_attack attack_script;
    public GameObject power_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text pp_text = power_object.GetComponent<Text>();
        pp_text.text = "PP:" + attack_script.PP.ToString();
    }
}
