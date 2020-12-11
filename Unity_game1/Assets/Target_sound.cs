using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_sound : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audioSource;
    public Target target_script;
    public int sound_jud = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sound_jud == 0 && target_script.hit_jud == 1)
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
