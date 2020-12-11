using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_text : MonoBehaviour
{
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = GetComponent<Text>();
        score_text.text = "Score:" + state_script.score.ToString();
    }
}
