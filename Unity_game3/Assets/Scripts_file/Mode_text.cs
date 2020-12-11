using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mode_text : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text mode_text = this.GetComponent<Text>();
        if (state_script.mode == 0)
        {
            mode_text.text = "mode:bomb";
        }
        if (state_script.mode == 1)
        {
            mode_text.text = "mode:powerbomb";
        }
        if (state_script.mode == 2)
        {
            mode_text.text = "mode:rocket";
        }
    }
}
