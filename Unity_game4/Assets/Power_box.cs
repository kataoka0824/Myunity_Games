using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_box : MonoBehaviour
{
    public GameObject box;
    GameObject p2_obj;
    State_2p p2_script;
    GameObject p1_obj;
    State_1p p1_script;
    public int hp;
    public GameObject hit_eff;
    public GameObject break_eff;
    public AudioClip damage;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(break_eff,
                        transform.position,
                        transform.rotation);
            Destroy(box);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bullet_2p")
        {
            p2_obj = GameObject.Find("Player2");
            p2_script = p2_obj.GetComponent<State_2p>();
            hp -= p2_script.power;
            p2_script.power_s += p2_script.power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
        if (collider.gameObject.tag == "bullet_1p")
        {
            p1_obj = GameObject.Find("Player1");
            p1_script = p1_obj.GetComponent<State_1p>();
            hp -= p1_script.power;
            p1_script.power_s += p1_script.power;
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
            p2_script.power_s += p2_script.explode_power;
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
            p1_script.power_s += p1_script.explode_power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
    }
}
