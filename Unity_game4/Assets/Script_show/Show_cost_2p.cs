using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_cost_2p : MonoBehaviour
{
    public State_2p state_2p_script;
    public GameObject text_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text cost_2p_text = text_obj.GetComponent<Text>();
        cost_2p_text.text = "2Pコスト: " + state_2p_script.cost.ToString();
    }
}
