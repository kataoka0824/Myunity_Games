using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode_2p : MonoBehaviour
{
    public GameObject explode;
    GameObject p2_obj;
    State_2p p2_script;
    public AudioClip explosion;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
        Destroy(explode, 0.5f);
        audioSource.PlayOneShot(explosion);
    }

    // Update is called once per frame
    void Update()
    {
        explode.transform.localScale = Vector3.one * p2_script.explode_power;
    }
}
