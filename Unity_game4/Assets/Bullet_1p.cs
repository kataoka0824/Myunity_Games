using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_1p : MonoBehaviour
{
    public GameObject bullet;
    public GameObject explode;
    GameObject p1_obj;
    State_1p p1_script;
    // Start is called before the first frame update
    void Start()
    {
        p1_obj = GameObject.Find("Player1");
        p1_script = p1_obj.GetComponent<State_1p>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
                    bullet.transform.position,
                    bullet.transform.rotation);
            }
            Destroy(bullet);
        }
    }
}
