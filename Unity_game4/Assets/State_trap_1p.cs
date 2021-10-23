using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_trap_1p : MonoBehaviour
{
    public GameObject trap;
    public int hp;
    public GameObject hit_eff;
    public GameObject break_eff;
    GameObject p1_obj;
    State_1p p1_script;
    GameObject p2_obj;
    State_2p p2_script;

    public AudioClip damage;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
        hp = 10 * p1_script.cost_trap;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject obj = Instantiate(break_eff,
                        trap.transform.position,
                        trap.transform.rotation);
            audioSource.PlayOneShot(damage);
            p2_script.cost_pre += 1 * p2_script.cost_trap;
            Destroy(trap);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bullet_2p")
        {
            p2_obj = GameObject.Find("Player2");
            p2_script = p2_obj.GetComponent<State_2p>();
            hp -= p2_script.power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
        if (collider.gameObject.tag == "explode_2p")
        {
            p2_obj = GameObject.Find("Player2");
            p2_script = p2_obj.GetComponent<State_2p>();
            hp -= p2_script.explode_power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
    }
}
