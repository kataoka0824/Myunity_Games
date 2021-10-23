using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve_bullet_1p : MonoBehaviour
{
    public GameObject curve_bullet;
    public GameObject explode;
    GameObject p1_obj;
    State_1p p1_script;
    GameObject p2_obj;
    public int speed;
    public int speed_rot;
    public int curve_time;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        p1_obj = GameObject.Find("Player1");
        p2_obj = GameObject.Find("Player2");
        p1_script = p1_obj.GetComponent<State_1p>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        curve_bullet.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (timer < curve_time)
        {
            var lookRotation = Quaternion.LookRotation(p2_obj.transform.position-curve_bullet.transform.position, Vector3.up);
            curve_bullet.transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed_rot);
        }
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "wall" ||
            collider.gameObject.tag == "castle_2p" ||
            collider.gameObject.tag == "trap_2p" ||
            collider.gameObject.tag == "Player2")
        {
            if (p1_script.explode_power > 0)
            {
                GameObject obj = Instantiate(explode,
                    curve_bullet.transform.position,
                    curve_bullet.transform.rotation);
            }
            Destroy(curve_bullet);
        }
    }
}
