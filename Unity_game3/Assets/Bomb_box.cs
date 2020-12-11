using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_box : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    void OnDestroy()
    {
        state_script.score += 1;
        state_script.bomb_re += 3;
    }
}
