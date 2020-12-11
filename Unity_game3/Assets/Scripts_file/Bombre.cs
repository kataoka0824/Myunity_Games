using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bombre : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text bomb_re_text = this.GetComponent<Text>();
        bomb_re_text.text = "×"+state_script.bomb_re.ToString();
    }
}
