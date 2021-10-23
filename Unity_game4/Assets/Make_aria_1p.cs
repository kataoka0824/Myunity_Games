using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_aria_1p : MonoBehaviour
{
    public GameObject area_obj;
    public int jud_obj;
    public Field_state field_script;
    Renderer m_Renderer;
    MeshRenderer mr;
    public byte toumei;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = area_obj.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 1)
        {
            area_obj.SetActive(true);
        }
        if (field_script.turn == 2)
        {
            jud_obj = 0;
            area_obj.SetActive(false);
        }
        if (field_script.turn_s_1p == 1)
        {
            jud_obj = 0;
        }
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "castle_1p"
                    || collider.gameObject.tag == "castle_2p"
                    || collider.gameObject.tag == "trap_1p"
                    || collider.gameObject.tag == "trap_2p"
                    || collider.gameObject.tag == "wall"
                    || collider.gameObject.tag == "Player2")
        {
            jud_obj = 1;
            m_Renderer.material.color = Color.red;
            mr = area_obj.GetComponent<MeshRenderer>();
            mr.material.color = mr.material.color - new Color32(0, 0, 0, toumei);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "castle_1p"
                    || collider.gameObject.tag == "castle_2p"
                    || collider.gameObject.tag == "trap_1p"
                    || collider.gameObject.tag == "trap_2p"
                    || collider.gameObject.tag == "wall"
                    || collider.gameObject.tag == "Player2")
        {
            jud_obj = 0;
            m_Renderer.material.color = Color.white;
            mr = area_obj.GetComponent<MeshRenderer>();
            mr.material.color = mr.material.color - new Color32(0, 0, 0, toumei);
        }
    }
}
