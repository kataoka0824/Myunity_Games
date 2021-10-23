using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_enemy : MonoBehaviour
{
    private int rand_jud_f_b;
    private int rand_jud_r_l;
    private float rand_time;
    private float rand_jump_time;
    private float time1;
    private float time2;
    private int jud_move=0;
    private int jud_jump=0;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        time2 += Time.deltaTime;
        if (jud_move==0)
        {
            rand_jud_f_b = Random.Range(0, 3);
            rand_jud_r_l = Random.Range(0, 3);
            rand_time = Random.Range(1, 5);
            jud_move = 1;
        }
        if (jud_move == 1)
        {
            if (rand_jud_f_b == 1)
            {
                transform.position += transform.forward * 30.0f * Time.deltaTime;
            }
            if (rand_jud_f_b == 2)
            {
                transform.position -= transform.forward * 30.0f * Time.deltaTime;
            }
            if (rand_jud_r_l == 1)
            {
                transform.position += transform.right * 30.0f * Time.deltaTime;
            }
            if (rand_jud_r_l == 2)
            {
                transform.position -= transform.right * 30.0f * Time.deltaTime;
            }
            if (time1 > rand_time)
            {
                jud_move = 0;
                time1 = 0;
            }
        }
        if (jud_jump == 0)
        {
            rand_jump_time = Random.Range(6,10);
            jud_jump = 1;
        }
        if (jud_jump == 1)
        {
            if (time2 > rand_jump_time)
            {
                rb.AddForce(Vector3.up * 20f, ForceMode.Impulse);
                jud_jump = 0;
                time2 = 0;
            }
        }
    }
}
