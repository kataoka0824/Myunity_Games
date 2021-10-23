using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject target;
    public GameObject ball;
    public GameObject main_camera;
    public Point point_script;
    public Sword_attack sword_attack_script;
    public int hit_jud = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = main_camera.transform.position;
		p.y = transform.position.y;
		transform.LookAt (p);
        transform.Rotate(0.0f, 180.0f, 0.0f);
        if (hit_jud == 1)
        {
            sword_attack_script.PP += 1;
            point_script.point += 3;
            target.SetActive(false);
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
