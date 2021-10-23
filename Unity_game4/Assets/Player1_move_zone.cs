using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_move_zone : MonoBehaviour
{
    public State_1p state_1p_script;
    public GameObject move_zone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move_zone.transform.localScale = new Vector3(state_1p_script.wall_scale, 8, state_1p_script.wall_scale);
    }
}
