using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Attack_bullet : MonoBehaviourPunCallbacks
{
    public GameObject player_attacker;
    public GameObject bullet;
    public float for_speed;
    private Rigidbody rb;
    private Vector3 hit_pos;
    private float time1;
    public float time_lim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time1<=time_lim)
        {
            time1 += Time.deltaTime;
        }
        if (photonView.IsMine)
        {
            if (Input.GetMouseButtonDown(1) && time1>=time_lim)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                hit_pos = hit.point;
                player_attacker.transform.LookAt(hit_pos);
                GameObject instance = PhotonNetwork.Instantiate("bullet",
                                       player_attacker.transform.position,
                                       Quaternion.identity);
                rb = instance.GetComponent<Rigidbody>();
                instance.transform.LookAt(hit_pos);
                rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);
                time1 = 0;
            }
        }
        
    }
    [PunRPC]
    private void attack_bullet()
    {
        
        player_attacker.transform.LookAt(hit_pos);
        GameObject instance = PhotonNetwork.Instantiate("bullet",
                               player_attacker.transform.position,
                               Quaternion.identity);
        rb = instance.GetComponent<Rigidbody>();
        instance.transform.LookAt(hit_pos);
        rb.AddForce(transform.forward * for_speed, ForceMode.Impulse);
    }
}
