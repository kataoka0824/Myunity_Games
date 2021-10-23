using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    //public GameObjrct ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider collision) {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (collision.gameObject.CompareTag("ground"))
            {
                Rigidbody rb = GetComponent<Rigidbody>();  // rigidbodyを取得
                Vector3 force = new Vector3(0.0f, 50.0f, 0.0f);  // 力を設定
                rb.AddForce(force, ForceMode.Impulse);
            }
            
        }
    }
}
