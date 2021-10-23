using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public GameObject wood;
    public GameObject main_camera;
    public Point point_script;
    public Sword_attack attack_script;
    public int hit_jud = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = main_camera.transform.position;
        p.y = transform.position.y;
        transform.LookAt(p);
        transform.Rotate(0.0f, 180.0f, 0.0f);
        if (hit_jud == 1)
        {
            point_script.point += 1;
            attack_script.PP += 1;
            wood.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("weapon"))
        {
            hit_jud = 1;
        }
    }
}
