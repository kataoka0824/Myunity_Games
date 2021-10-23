using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_mode : MonoBehaviour
{
    public Field_state field_script;
    public Player1 player1_script;
    public Player2 player2_script;
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
            if (player1_script.mode == 0)
            {
                Text turn_text = text_obj.GetComponent<Text>();
                turn_text.text = "mode:castle1";
            }
            if (player1_script.mode == 1)
            {
                Text turn_text = text_obj.GetComponent<Text>();
                turn_text.text = "mode:trap1";
            }
        }
        if (field_script.turn == 2)
        {
            if (player2_script.mode == 0)
            {
                Text turn_text = text_obj.GetComponent<Text>();
                turn_text.text = "mode:castle1";
            }
            if (player2_script.mode == 1)
            {
                Text turn_text = text_obj.GetComponent<Text>();
                turn_text.text = "mode:trap1";
            }
        }
    }
}
