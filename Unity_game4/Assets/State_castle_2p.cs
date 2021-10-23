using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_castle_2p : MonoBehaviour
{
    public GameObject castle;
    int hp;
    public GameObject hit_eff;
    public GameObject care_eff;
    public GameObject break_eff;
    public int jud_care;
    GameObject p1_obj;
    State_1p p1_script;
    GameObject p2_obj;
    State_2p p2_script;
    GameObject field;
    Field_state field_script;
    public AudioClip damage;
    AudioSource audioSource;
    public AudioClip care_sound;
    // Start is called before the first frame update
    void Start()
    {
        jud_care = 0;
        audioSource = GetComponent<AudioSource>();
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
        field = GameObject.Find("field_state");
        field_script = field.GetComponent<Field_state>();
        hp = p1_script.castle_hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject obj = Instantiate(break_eff,
                        castle.transform.position,
                        castle.transform.rotation);
            audioSource.PlayOneShot(damage);
            p1_script.cost_pre += 1 * p1_script.cost_castle;
            Destroy(castle);
        }
        if (field_script.turn_s_2p == 1 && jud_care == 0 && p2_script.care > 0)
        {
            GameObject obj = Instantiate(care_eff,
                        castle.transform.position,
                        castle.transform.rotation);
            jud_care = 1;
            audioSource.PlayOneShot(care_sound);
            Destroy(obj, 1.0f);
            p2_script.hp += p2_script.care;
        }
        if (field_script.turn_s_2p == 0)
        {
            jud_care = 0;
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bullet_1p")
        {
            p1_obj = GameObject.Find("Player1");
            p1_script = p1_obj.GetComponent<State_1p>();
            hp -= p1_script.power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
        if (collider.gameObject.tag == "explode_1p")
        {
            p1_obj = GameObject.Find("Player1");
            p1_script = p1_obj.GetComponent<State_1p>();
            hp -= p1_script.explode_power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
    }
}
