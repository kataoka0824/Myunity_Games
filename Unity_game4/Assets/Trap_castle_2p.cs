using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_castle_2p : MonoBehaviour
{
    public GameObject trap_castle;
    public GameObject curve_bullet;
    GameObject field;
    Field_state field_script;
    public int jud_attack;
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
            GameObject obj = Instantiate(curve_bullet,
                        trap_castle.transform.position +
                        trap_castle.transform.forward * 5.0f,
                        Quaternion.Euler(0, 180, 0));
            GameObject obj_2 = Instantiate(curve_bullet,
                        trap_castle.transform.position +
                        trap_castle.transform.forward * -5.0f,
                        Quaternion.Euler(0, 0, 0));
            GameObject obj_3 = Instantiate(curve_bullet,
                        trap_castle.transform.position +
                        trap_castle.transform.right * 5.0f,
                        Quaternion.Euler(0, -90, 0));
            GameObject obj_4 = Instantiate(curve_bullet,
                        trap_castle.transform.position +
                        trap_castle.transform.right * -5.0f,
                        Quaternion.Euler(0, 90, 0));
            jud_attack = 1;
            audioSource.PlayOneShot(attack);
        }
        if (field_script.turn_s_2p == 0)
        {
            jud_attack = 0;
        }
    }
}
