using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.rotation = Quaternion.LookRotation(player.transform.position);
        this.gameObject.transform.LookAt(new Vector3(player.transform.position.x,
                                         enemy.transform.position.y,
                                         player.transform.position.z));
    }
}
