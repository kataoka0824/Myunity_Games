using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    //public GamrObject ground;
    public int jump_jud = 0;
    public UnityEvent OnEnterGround;
    public GameObject sword;
    public float ani_len;
    public float ani_time;
    public int sword_jud = 0;
    public Animator ani;
    //public AnimatorStateInfo inf_ani;
    // Start is called before the first frame update
    void Start()
    {
        /*ani = GetComponent<Animator>();
        ani_len = ani.GetCurrentAnimatorStateInfo(0).length;
        ani_time = 0;*/
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ball.transform.Translate(Vector3.forward * 1.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ball.transform.Translate(Vector3.forward * -1.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            sword_jud = 1;
            
        }
        if (sword_jud == 1)
        {
            sword.SetActive(true);
            def_sword();
        }
    }
    void def_sword()
    {
        
        ani_time += 0.1f;
        if (ani_time > 1.5f)
        {
            def_sword_del();
        }
    }
    void def_sword_del()
    {
        ani_time = 0;
        sword_jud = 0;
        sword.SetActive(false);
    }
}
