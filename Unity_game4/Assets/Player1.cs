using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public GameObject player;
    public Field_state field_script;
    public int mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (field_script.turn == 1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.transform.Translate(0.0f, 0.0f, 0.2f);
                player.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //player.transform.Translate(0.0f, 0.0f, -0.5f);
                player.transform.Translate(0.0f, 0.0f, 0.2f);
                player.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //player.transform.Translate(0.5f, 0.0f, 0.0f);
                player.transform.Translate(0.0f, 0.0f, 0.2f);
                player.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //player.transform.Translate(-0.5f, 0.0f, 0.0f);
                player.transform.Translate(0.0f, 0.0f, 0.2f);
                player.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
        }
        
    }
}
