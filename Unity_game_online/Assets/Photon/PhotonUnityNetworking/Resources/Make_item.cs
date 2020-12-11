using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class Make_item : MonoBehaviourPunCallbacks
{
    public Make_room room_script;
    public float time1;
    public float time_lim;
    public Vector3 v1;
    public int item_re;
    public int item_jud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        if (room_script.master == true && time1>time_lim)
        {
            for (int i = 0; i < item_re; i++)
            {
                item_jud = Random.Range(0, 3);
                if (item_jud == 0)
                {
                    v1 = new Vector3(Random.Range(0f, 1000f), 20f, Random.Range(0f, 1000f));
                    GameObject instance = PhotonNetwork.Instantiate("block_box", v1, Quaternion.identity);
                }
                else if (item_jud == 1)
                {
                    v1 = new Vector3(Random.Range(0f, 1000f), 20f, Random.Range(0f, 1000f));
                    GameObject instance = PhotonNetwork.Instantiate("trap1_box", v1, Quaternion.identity);
                }
                else if (item_jud == 2)
                {
                    v1 = new Vector3(Random.Range(0f, 1000f), 20f, Random.Range(0f, 1000f));
                    GameObject instance = PhotonNetwork.Instantiate("HP_box", v1, Quaternion.identity);
                }
            }
            time1 = 0;
        }
    }
}
