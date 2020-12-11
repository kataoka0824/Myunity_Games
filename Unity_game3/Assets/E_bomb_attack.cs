using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_bomb_attack : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bomb;
    public Rigidbody rb;
    public float for_speed;
    public float up_speed;
    public float time_lag;
    public float time_lag2;
    private float time1 = 0;
    private float time2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        time2 += Time.deltaTime;
        if (time1 > time_lag)
        {
            GameObject instance = (GameObject)Instantiate(bomb,
                                   enemy.transform.position + 
                                   enemy.transform.forward * 10.0f+
                                   enemy.transform.up * 20.0f,
                                   Quaternion.Euler(0, enemy.transform.rotation.eulerAngles.y, 0));
            rb = instance.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);
            rb.AddForce(Vector3.up * up_speed, ForceMode.Impulse);
            time1 = 0;
        }
        if (time2 > time_lag2)
        {
            GameObject instance = (GameObject)Instantiate(bomb,
                                   enemy.transform.position +
                                   enemy.transform.forward * 10.0f +
                                   enemy.transform.up * 25.0f,
                                   Quaternion.Euler(0, enemy.transform.rotation.eulerAngles.y, 0));
            rb = instance.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * for_speed/2, ForceMode.Impulse);
            rb.AddForce(Vector3.up * up_speed, ForceMode.Impulse);
            time2 = 0;
        }
    }
}
