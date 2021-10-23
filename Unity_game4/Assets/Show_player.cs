using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_player : MonoBehaviour
{
    public Field_state field_script;
    public GameObject turn_p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text turn_text = turn_p.GetComponent<Text>();
        turn_text.text = field_script.turn.ToString() + "P";
    }
}
