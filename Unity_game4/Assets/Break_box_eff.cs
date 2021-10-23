using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_box_eff : MonoBehaviour
{
    public GameObject break_eff;
    public AudioClip break_sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(break_sound);
        Destroy(break_eff, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
