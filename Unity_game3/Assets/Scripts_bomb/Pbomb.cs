using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pbomb : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject pbomb;
    public GameObject explode2;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("del_pbomb", 5f);
    }
    void del_pbomb()
    {
        GameObject instance = (GameObject)Instantiate(explode2,
                                   pbomb.transform.position,
                                   Quaternion.identity);
        Destroy(pbomb);
    }
    void OnDestroy()
    {
        
    }
}
