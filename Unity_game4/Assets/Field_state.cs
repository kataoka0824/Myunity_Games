using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_state : MonoBehaviour
{
    public int turn;
    public int turn_1p;
    public int turn_2p;
    public int turn_s_1p;
    public int turn_s_2p;
    public State_1p state_1p_script;
    public State_2p state_2p_script;
    public int all_turn;
    int time;

    // Start is called before the first frame update
    void Start()
    {
        turn = 1;
        turn_s_1p = 1;
        Invoke("Turn_0_1p", 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        time += 1;
    }
    public void Change_turn()
    {
        if (turn == 2 && time > 60)
        {
            time = 0;
            turn = 1;
            turn_1p = 1;
            turn_s_1p = 1;
            state_1p_script.cost += state_1p_script.cost_up;
            Invoke("Turn_0_1p", 0.2f);
            all_turn += 1;
        }
        else if (turn == 1 && time > 60)
        {
            time = 0;
            turn = 2;
            turn_2p = 1;
            turn_s_2p = 1;
            state_2p_script.cost += state_2p_script.cost_up;
            Invoke("Turn_0_2p", 0.2f);
            all_turn += 1;
        }

    }
    void Turn_0_1p()
    {
        turn_s_1p = 0;
    }
    void Turn_0_2p()
    {
        turn_s_2p = 0;
    }
}
