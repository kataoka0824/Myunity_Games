using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_box : MonoBehaviour
{
    public GameObject power_box;
    public GameObject hp_box;
    public GameObject bomb_box;
    public GameObject care_box;
    public GameObject move_box;
    public GameObject trap_castle_box;
    public float rand_x;
    public float rand_y;
    private int rand_box;
    public Field_state field_script;
    int jud;
    int jud_trap_castle_box;
    // Start is called before the first frame update
    void Start()
    {
        jud = 1;
        jud_trap_castle_box = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.all_turn % 5 == 0 && jud == 0)
        {
            rand_x = Random.Range(-20f, 20f);
            rand_y = Random.Range(-20f, 20f);
            rand_box = Random.Range(0, 5);
            if (rand_box == 0)
            {
                GameObject obj = Instantiate(power_box,
                        new Vector3(rand_x,2.5f,rand_y),
                        Quaternion.identity);
                jud = 1;
            }
            if (rand_box == 1)
            {
                GameObject obj = Instantiate(hp_box,
                        new Vector3(rand_x, 2.5f, rand_y),
                        Quaternion.identity);
                jud = 1;
            }
            if (rand_box == 2)
            {
                GameObject obj = Instantiate(bomb_box,
                        new Vector3(rand_x, 2.5f, rand_y),
                        Quaternion.identity);
                jud = 1;
            }
            if (rand_box == 3)
            {
                GameObject obj = Instantiate(care_box,
                        new Vector3(rand_x, 2.5f, rand_y),
                        Quaternion.identity);
                jud = 1;
            }
            if (rand_box == 4)
            {
                GameObject obj = Instantiate(move_box,
                        new Vector3(rand_x, 2.5f, rand_y),
                        Quaternion.identity);
                jud = 1;
            }
        }
        if (field_script.all_turn % 7 == 0 && jud_trap_castle_box == 0)
        {
            rand_x = Random.Range(-20f, 20f);
            rand_y = Random.Range(-20f, 20f);
            GameObject obj = Instantiate(trap_castle_box,
                        new Vector3(rand_x, 2.5f, rand_y),
                        Quaternion.identity);
            jud_trap_castle_box = 1;
        }
        if (field_script.all_turn % 5 == 1)
        {
            jud = 0;
        }
        if (field_script.all_turn % 7 == 1)
        {
            jud_trap_castle_box = 0;
        }
    }
}
