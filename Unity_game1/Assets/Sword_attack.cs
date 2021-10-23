using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sword_attack : MonoBehaviour
{
    public int PP = 10;
    public GameObject attack;
    public GameObject ball;
    public Ball ball_script;
    public AudioClip sound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        attack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.S) && PP>=3 && attack.activeSelf==false)
        {
            attack.SetActive(true);
            attack.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y - 2.0f, ball.transform.position.z);
            attack.transform.rotation = ball.transform.rotation;
            def_attack();
            
        }
    }
    void def_attack()
    {
        
        Rigidbody rb = attack.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = ball.transform.forward * 3500;    // 力を設定
        rb.AddForce(force);  // 力を加える
        ball_script.sword_jud = 1;
        audioSource.PlayOneShot(sound);
        PP -= 3;
        Invoke("def_attack_del",3);
    }
    void def_attack_del()
    {
        Rigidbody rb = attack.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        attack.SetActive(false);
    }
}
