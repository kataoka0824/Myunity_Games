using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve_bullet_2p : MonoBehaviour
{
    public GameObject curve_bullet;
    public GameObject explode;
    GameObject p2_obj;
    State_2p p2_script;
    GameObject p1_obj;
    public int speed;
    public int speed_rot;
    public int curve_time;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        p1_obj = GameObject.Find("Player1");
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        curve_bullet.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (timer < curve_time)
        {
            var lookRotation = Quaternion.LookRotation(p1_obj.transform.position - curve_bullet.transform.position, Vector3.up);
            curve_bullet.transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed_rot);
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "wall" ||
            collider.gameObject.tag == "castle_1p" ||
            collider.gameObject.tag == "trap_1p" ||
            collider.gameObject.tag == "Player1")
        {
            if (p2_script.explode_power > 0)
            {
                GameObject obj = Instantiate(explode,
                    curve_bullet.transform.position,
                    curve_bullet.transform.rotation);
            }
            Destroy(curve_bullet);
        }
    }
}
