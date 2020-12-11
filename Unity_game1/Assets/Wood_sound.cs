using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wood_sound : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audioSource;
    public GameObject wood;
    public Wood wood_script;
    public int sound_jud = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sound_jud == 0 && wood_script.hit_jud == 1)
        {
            sound_jud = 1;

        }
        if (sound_jud == 1)
        {
            audioSource.PlayOneShot(sound);
            sound_jud = 2;
        }
    }
}
