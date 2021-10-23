using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat_player : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(player.transform.position);
    }
}
