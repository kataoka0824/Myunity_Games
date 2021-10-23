using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_2p_1 : MonoBehaviour
{
    public GameObject trap1;
    public GameObject bullet1;
    GameObject field;
    Field_state field_script;
    public int jud_attack;
    Rigidbody rb;
    public AudioClip attack;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        jud_attack = 0;
        field = GameObject.Find("field_state");
        field_script = field.GetComponent<Field_state>();
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn_s_2p == 1 && jud_attack == 0)
        {
            GameObject obj = Instantiate(bullet1,
                        trap1.transform.position +
                        trap1.transform.forward * 5.0f,
                        trap1.transform.rotation);
            rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(trap1.transform.forward * 40.0f, ForceMode.Impulse);
            jud_attack = 1;
            audioSource.PlayOneShot(attack);
        }
        if (field_script.turn_s_2p == 0)
        {
            jud_attack = 0;
        }
    }
}
