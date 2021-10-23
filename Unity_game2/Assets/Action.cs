using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public Fire fire_script;
    //public GameObject fire_obj;
    //public Ice ice_script;
    //public GameObject ice_obj;
    //public Thunder thunder_script;
    //public GameObject thunder_obj;
    public Vector3 hit_pos;
    public int elem_mode = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            elem_mode = 0;
            Debug.Log(elem_mode);
        }
        if (Input.GetKey(KeyCode.I))
        {
            elem_mode = 1;
            Debug.Log(elem_mode);
        }
        if (Input.GetKey(KeyCode.S))
        {
            elem_mode = 2;
            Debug.Log(elem_mode);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            //Debug.Log(hit.point);
            hit_pos = hit.point;
            if (fire_script.fire_mode != 1)
            {
                if (elem_mode == 0)
                {
                    //fire_obj.SetActive(true);
                    fire_script.fire_mode = 1;
                }

            }
            /*if (ice_script.ice_mode != 1)
            {
                if (elem_mode == 1)
                {
                    ice_obj.SetActive(true);
                    ice_script.ice_mode = 0;
                }

            }
            if (thunder_script.thunder_mode != 1)
            {
                if (elem_mode == 2)
                {
                    thunder_obj.SetActive(true);
                    thunder_script.thunder_mode = 0;
                }

            }*/
        }
    }
}
