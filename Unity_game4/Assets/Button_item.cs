using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_item : MonoBehaviour
{
    public Field_state field_script;
    public Player1 player1_script;
    public Player2 player2_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Set_Castle1()
    {
        if (field_script.turn == 1)
        {
            player1_script.mode = 0;
        }
        else if (field_script.turn == 2)
        {
            player2_script.mode = 0;
        }
    }
    public void Set_Trap1()
    {
        if (field_script.turn == 1)
        {
            player1_script.mode = 1;
        }
        else if (field_script.turn == 2)
        {
            player2_script.mode = 1;
        }
    }
}
