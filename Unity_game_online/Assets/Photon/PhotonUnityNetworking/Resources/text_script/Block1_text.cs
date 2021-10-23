using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block1_text : MonoBehaviour
{
    public GameObject block_text1;
    public State state_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text text1 = block_text1.GetComponent<Text>();
        text1.text = "×" + state_script.block_re.ToString();
    }
}
