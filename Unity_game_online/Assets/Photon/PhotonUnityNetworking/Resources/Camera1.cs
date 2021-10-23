using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Camera1 : MonoBehaviourPunCallbacks
{
    public bool master = false;
    public GameObject player;
    public GameObject player2;
    public Make_room make_room_script;
    public GameObject camera_1p_cy;
    public GameObject camera_2p_cy;
    public Vector3 v1;
    public Vector3 v2;
    private float rot_x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (master == true)//一人目の場合
        {
            camera_1p_cy.SetActive(true);
            camera_2p_cy.SetActive(false);
            camera_1p_cy.transform.position = v1 + Vector3.up * 20f;
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                camera_1p_cy.transform.Translate(0.8f, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                camera_1p_cy.transform.Translate(-0.8f, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                camera_1p_cy.transform.Translate(0.0f, 0.0f, 0.8f);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                camera_1p_cy.transform.Translate(0.0f, 0.0f, -0.8f);
            }
            if (Input.GetMouseButton(0))
            {
                //Debug.Log(Input.GetAxis("Mouse X"));
                rot_x = Input.GetAxis("Mouse X");
                camera_1p_cy.transform.Rotate(0.0f, -rot_x * 2, 0.0f);
            }
        }
        else if(master==false)//二人目のプレイヤーの場合
        {
            camera_1p_cy.SetActive(false);
            camera_2p_cy.SetActive(true);
            camera_2p_cy.transform.position = make_room_script.v2 + Vector3.up * 20f;
        }
    }
    public override void OnCreatedRoom()
    {
        master = true;
        Debug.Log("OnCreatedRoom");
    }
    public override void OnJoinedRoom()
    {
        if (master)
        {
            v1 = new Vector3(Random.Range(0f, 1000f), 10f, Random.Range(0f, 1000f));
            GameObject player1 = PhotonNetwork.Instantiate("GamePlayer1", v1, Quaternion.identity);
        }
        else
        {
            v2 = new Vector3(Random.Range(0f, 1000f), 10f, Random.Range(0f, 1000f));
            GameObject player2 = PhotonNetwork.Instantiate("GamePlayer2", v2, Quaternion.identity);
        }
    }


}
