using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_state : MonoBehaviour
{
    public int e_hp;
    public State state_script;
    public int get_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e_hp <= 0)
        {
            state_script.bomb_re += 1;
            state_script.pbomb_re+=1;
            state_script.rocket_re+=1;
            state_script.kill += 1;
            state_script.score += get_score;
            Destroy(this.gameObject);
        }
    }
}
