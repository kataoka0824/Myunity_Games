using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_turn : MonoBehaviour
{
    public GameObject camera1;
    public Field_state field_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 1)
        {
            camera1.transform.rotation = Quaternion.Euler(90, 0, 0);
        }
        else if (field_script.turn == 2)
        {
            camera1.transform.rotation = Quaternion.Euler(90, 180, 0);
        }
    }
}
