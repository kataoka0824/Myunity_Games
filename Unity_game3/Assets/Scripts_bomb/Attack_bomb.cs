using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_bomb : MonoBehaviour
{
    public GameObject player;
    public GameObject bomb;
    public Rigidbody rb;
    public State state_script;
    public float for_speed;
    public float up_speed;
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject instance = (GameObject)Instantiate(bomb,
                               new Vector3(player.transform.position.x,
                                           player.transform.position.y,
                                           player.transform.position.z+4.0f),
                               Quaternion.identity);*/
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && state_script.mode==0
            && state_script.bomb_re > 0)
        {
            GameObject instance = (GameObject)Instantiate(bomb,
                               player.transform.position + player.transform.forward * 10.0f,
                               Quaternion.Euler(0,player.transform.rotation.eulerAngles.y,0));
            rb = instance.GetComponent<Rigidbody>();
            Debug.Log(player.transform.rotation.eulerAngles);
            rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);
            rb.AddForce(Vector3.up * up_speed, ForceMode.Impulse);
            state_script.bomb_re -= 1;
        }
    }
}
