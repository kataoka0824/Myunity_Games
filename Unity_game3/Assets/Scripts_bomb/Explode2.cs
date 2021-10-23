using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode2 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("del_explode", 1.0f);
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void del_explode()
    {
        Destroy(this.gameObject);
    }
}
