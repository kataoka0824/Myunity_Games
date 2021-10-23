using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode_1p : MonoBehaviour
{
    public GameObject explode;
    GameObject p1_obj;
    State_1p p1_script;
    public AudioClip explosion;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
        Destroy(explode, 0.5f);
        audioSource.PlayOneShot(explosion);
    }

    // Update is called once per frame
    void Update()
    {
        explode.transform.localScale = Vector3.one * p1_script.explode_power;
    }
}
