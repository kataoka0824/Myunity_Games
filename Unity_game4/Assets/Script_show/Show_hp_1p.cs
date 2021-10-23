using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_hp_1p : MonoBehaviour
{
    public State_1p state_1p_script;
    public GameObject text_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text hp_1p_text = text_obj.GetComponent<Text>();
        hp_1p_text.text = "1P HP: " + state_1p_script.hp.ToString();
    }
}
