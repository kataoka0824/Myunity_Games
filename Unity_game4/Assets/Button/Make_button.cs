using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Make_button : MonoBehaviour
{
    public GameObject castle_1p;
    public GameObject trap_1p;
    public GameObject trap_castle_1p;
    public GameObject castle_2p;
    public GameObject trap_2p;
    public GameObject trap_castle_2p;
    public GameObject player_1p;
    public GameObject player_2p;
    public Field_state field_script;
    public State_1p state_1p_script;
    public State_2p state_2p_script;
    public Make_aria_1p make_1p_script;
    public Make_aria_2p make_2p_script;
    public AudioClip put_trap;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Put_trap()
    {
        if (field_script.turn == 1)
        {
            if (make_1p_script.jud_obj == 0 && state_1p_script.cost >= state_1p_script.cost_trap)
            {
                GameObject obj = Instantiate(trap_1p,
                    player_1p.transform.position +
                    player_1p.transform.forward * 5.0f,
                    player_1p.transform.rotation);
                state_1p_script.cost -= state_1p_script.cost_trap;
            }
        }
        if (field_script.turn == 2)
        {
            if (make_2p_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_trap)
            {
                GameObject obj = Instantiate(trap_2p,
                    player_2p.transform.position +
                    player_2p.transform.forward * 5.0f,
                    player_2p.transform.rotation);
                state_2p_script.cost -= state_2p_script.cost_trap;
            }
        }
    }
    public void Put_castle()
    {
        if (field_script.turn == 1)
        {
            if (make_1p_script.jud_obj == 0 && state_1p_script.cost >= state_1p_script.cost_castle)
            {
                GameObject obj = Instantiate(castle_1p,
                    player_1p.transform.position +
                    player_1p.transform.forward * 5.0f,
                    player_1p.transform.rotation);
                state_1p_script.cost -= state_1p_script.cost_castle;
            }
        }
        if (field_script.turn == 2)
        {
            if (make_2p_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_castle)
            {
                GameObject obj = Instantiate(castle_2p,
                    player_2p.transform.position +
                    player_2p.transform.forward * 5.0f,
                    player_2p.transform.rotation);
                state_2p_script.cost -= state_2p_script.cost_castle;
            }
        }
    }
    public void Put_trap_castle()
    {
        if (field_script.turn == 1)
        {
            if (make_1p_script.jud_obj == 0 && state_1p_script.cost >= state_1p_script.cost_trap + state_1p_script.cost_castle && state_1p_script.trap_castle > 0)
            {
                GameObject obj = Instantiate(trap_castle_1p,
                    player_1p.transform.position +
                    player_1p.transform.forward * 5.0f,
                    player_1p.transform.rotation);
                state_1p_script.cost -= (state_1p_script.cost_trap + state_1p_script.cost_castle);
                state_1p_script.trap_castle -= 1;
                audioSource.PlayOneShot(put_trap);
            }
        }
        if (field_script.turn == 2)
        {
            if (make_2p_script.jud_obj == 0 && state_2p_script.cost >= state_2p_script.cost_trap + state_2p_script.cost_castle && state_2p_script.trap_castle > 0)
            {
                GameObject obj = Instantiate(trap_castle_2p,
                    player_2p.transform.position +
                    player_2p.transform.forward * 5.0f,
                    player_2p.transform.rotation);
                state_2p_script.cost -= (state_2p_script.cost_trap + state_2p_script.cost_castle);
                state_2p_script.trap_castle -= 1;
                audioSource.PlayOneShot(put_trap);
            }
        }
    }
}
