using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_2p : MonoBehaviour
{
    public GameObject walls;
    public Field_state field_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 2)
        {
            walls.SetActive(true);
        }
        if (field_script.turn == 1)
        {
            walls.SetActive(false);
        }
    }
}
