using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_p : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        state_script.mode = 1;
    }
}
