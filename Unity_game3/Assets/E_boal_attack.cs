using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_boal_attack : MonoBehaviour
{
    public Boal boal_script;
    public GameObject enemy;
    public GameObject boal;
    public GameObject player;
    public Rigidbody rb;
    public float for_speed;
    public float time_lag;
    public float time_lim;
    public GameObject explode2;
    private int jud = 0;
    private float time1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = enemy.transform.position;
        time1 += Time.deltaTime;
        if (time1 > time_lag)
        {
            boal.SetActive(true);
            /*GameObject instance = (GameObject)Instantiate(boal,
                                   enemy.transform.position +
                                   enemy.transform.up * 30.0f +
                                   enemy.transform.forward * 10.0f,
                                   Quaternion.identity);
            instance.transform.LookAt(player.transform.position);
            rb = instance.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);*/
            pos.y += 30.0f;
            boal.transform.position = pos;
            time1 = 0;
            jud = 0;
        }
        if (time1 > time_lim)
        {
            if (jud == 0 && boal.activeSelf == true)
            {
                GameObject instance = (GameObject)Instantiate(explode2,
                                        boal.transform.position,
                                        Quaternion.identity);
                boal.SetActive(false);
                jud = 1;
            }
        }
    }
}
