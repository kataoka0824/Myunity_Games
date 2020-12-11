using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_hp_text : MonoBehaviour
{
    public E_state e_state_script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh mode_text = this.GetComponent<TextMesh>();
        mode_text.text = "HP:" + e_state_script.e_hp.ToString();
    }
}
