using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_eff : MonoBehaviour
{
    public GameObject break_eff;
    public AudioClip explosion;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(explosion);
        Destroy(break_eff, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
