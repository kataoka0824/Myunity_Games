using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocketre : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text rocket_re_text = this.GetComponent<Text>();
        rocket_re_text.text = "×" + state_script.rocket_re.ToString();
    }
}
