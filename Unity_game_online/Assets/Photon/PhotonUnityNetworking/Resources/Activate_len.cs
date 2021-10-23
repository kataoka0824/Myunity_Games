using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activate_len : MonoBehaviour
{
    public GameObject act_text;
    public Make_room make_room_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text text1 = act_text.GetComponent<Text>();
        text1.text=make_room_script.master.ToString();
    }
}
