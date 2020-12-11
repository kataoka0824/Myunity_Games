using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Trap1 : MonoBehaviourPunCallbacks
{
    private float time1;
    public float time_lim;
    public GameObject trap_attacker;
    public float for_speed;
    private Rigidbody rb1;
    private Rigidbody rb2;
    private Rigidbody rb3;
    private Rigidbody rb4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time1 <= time_lim)
        {
            time1 += Time.deltaTime;
        }
        if (photonView.IsMine)
        {
            if (time1 >= time_lim)
            {
                GameObject instance1 = PhotonNetwork.Instantiate("bullet_1",
                                               trap_attacker.transform.position + Vector3.forward*15f,
                                               Quaternion.identity);
                rb1 = instance1.GetComponent<Rigidbody>();
                rb1.AddForce(transform.forward * for_speed, ForceMode.Impulse);
                GameObject instance2 = PhotonNetwork.Instantiate("bullet_1",
                                               trap_attacker.transform.position - Vector3.forward * 15f,
                                               Quaternion.identity);
                rb2 = instance2.GetComponent<Rigidbody>();
                rb2.AddForce(-transform.forward * for_speed, ForceMode.Impulse);
                GameObject instance3 = PhotonNetwork.Instantiate("bullet_1",
                                               trap_attacker.transform.position + Vector3.right * 15f,
                                               Quaternion.identity);
                rb3 = instance3.GetComponent<Rigidbody>();
                rb3.AddForce(transform.right * for_speed, ForceMode.Impulse);
                GameObject instance4 = PhotonNetwork.Instantiate("bullet_1",
                                               trap_attacker.transform.position - Vector3.right * 15f,
                                               Quaternion.identity);
                rb4 = instance4.GetComponent<Rigidbody>();
                rb4.AddForce(-transform.right * for_speed, ForceMode.Impulse);
                time1 = 0;
            }
        }
    }
}
