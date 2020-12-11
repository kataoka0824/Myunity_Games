using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_beam_attack : MonoBehaviour
{
    public GameObject enemy;
    public GameObject beam;
    public GameObject player;
    public Rigidbody rb;
    public float for_speed;
    public float time_lag;
    private float time1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        if (time1 > time_lag)
        {
            GameObject instance = (GameObject)Instantiate(beam,
                                   enemy.transform.position +
                                   enemy.transform.up * 15.0f,
                                   Quaternion.identity);
            instance.transform.LookAt(player.transform.position);
            rb = instance.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);

            time1 = 0;
        }
    }
}
