using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_2p : MonoBehaviour
{
    public GameObject castle1;
    public GameObject trap1;
    public GameObject trap_castle1;
    public GameObject player;
    public Field_state field_script;
    public int jud_obj_c;
    public Player2 player_script;
    public State_2p state_2p_script;
    public Make_aria_2p make_script;
    public AudioClip put_trap;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        jud_obj_c = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 2 && Input.GetKeyDown(KeyCode.C))
        {
            if (make_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_castle)
            {
                GameObject obj = Instantiate(castle1,
                    player.transform.position +
                    player.transform.forward * 5.0f,
                    player.transform.rotation);
                state_2p_script.cost -= state_2p_script.cost_castle;
            }
            jud_obj_c = 0;
        }
        if (field_script.turn == 2 && Input.GetKeyDown(KeyCode.T))
        {
            if (make_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_trap)
            {
                GameObject obj = Instantiate(trap1,
                    player.transform.position +
                    player.transform.forward * 5.0f,
                    player.transform.rotation);
                state_2p_script.cost -= state_2p_script.cost_trap;
            }
            jud_obj_c = 0;
        }
        if (field_script.turn == 2 && Input.GetKeyDown(KeyCode.B))
        {
            if (make_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_trap + state_2p_script.cost_castle && state_2p_script.trap_castle > 0)
            {
                GameObject obj = Instantiate(trap_castle1,
                    player.transform.position +
                    player.transform.forward * 5.0f,
                    player.transform.rotation);
                state_2p_script.cost -= (state_2p_script.cost_trap + state_2p_script.cost_castle);
                state_2p_script.trap_castle -= 1;
                audioSource.PlayOneShot(put_trap);
            }
            jud_obj_c = 0;
        }
    }
}
