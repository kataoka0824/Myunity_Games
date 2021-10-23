using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sword : MonoBehaviour
{
    public GameObject ball;
    public AudioClip sound;
    public AudioSource audioSource;
    public Ball ball_script;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y-8.0f, ball.transform.position.z);
        if (ball_script.sword_jud == 1)
        {
            
        }
    }
    void OnEnable()
    {
        audioSource.PlayOneShot(sound);
    }
}
