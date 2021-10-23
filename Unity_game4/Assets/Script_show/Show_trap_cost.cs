using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_trap_cost : MonoBehaviour
{
    public Field_state field_script;
    public State_1p state_1p_script;
    public State_2p state_2p_script;
    public GameObject text_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 1)
        {
            Text power_text = text_obj.GetComponent<Text>();
            power_text.text = "1Pトラップコスト:" + state_1p_script.cost_trap.ToString();
        }
        if (field_script.turn == 2)
        {
            Text power_text = text_obj.GetComponent<Text>();
            power_text.text = "2Pトラップコスト:" + state_2p_script.cost_trap.ToString();
        }
    }
}
