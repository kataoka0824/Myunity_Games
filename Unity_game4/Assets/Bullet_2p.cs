using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_2p : MonoBehaviour
{
    public GameObject bullet;
    public GameObject explode;
    GameObject p2_obj;
    State_2p p2_script;
    // Start is called before the first frame update
    void Start()
    {
        p2_obj = GameObject.Find("Player2");
        p2_script = p2_obj.GetComponent<State_2p>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
                    bullet.transform.position,
                    bullet.transform.rotation);
            }
            Destroy(bullet);
        }
    }
}
