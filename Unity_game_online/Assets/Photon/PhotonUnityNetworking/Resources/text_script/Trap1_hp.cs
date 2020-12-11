using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap1_hp : MonoBehaviour
{
    public GameObject trap1_text1;
    public Trap1_1 trap1_1_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh text1 = trap1_text1.GetComponent<TextMesh>();
        text1.text = "HP:" + trap1_1_script.trap1_hp.ToString();
    }
}
