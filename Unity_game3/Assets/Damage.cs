using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject explode;
    public GameObject explode2;
    public State state_script;
    public GameObject damage_motion;
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage_motion.activeSelf)
        {
            Invoke("Damage_motion_del", 0.5f);
        }
    }
    void Damage_motion_del()
    {
        damage_motion.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "explode")
        {
            state_script.hp -= 5;
            damage_motion.SetActive(true);
            audioSource.PlayOneShot(sound1);

        }
        if (collider.gameObject.tag == "explode2")
        {
            state_script.hp -= 10;
            damage_motion.SetActive(true);
            audioSource.PlayOneShot(sound1);
        }
        if (collider.gameObject.tag == "explode3")
        {
            state_script.hp -= 3;
            damage_motion.SetActive(true);
            audioSource.PlayOneShot(sound1);
        }
        if (collider.gameObject.tag == "explode4")
        {
            state_script.hp -= 2;
            damage_motion.SetActive(true);
            audioSource.PlayOneShot(sound1);
        }
    }
}
