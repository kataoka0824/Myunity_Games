using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explain : MonoBehaviour
{
    public GameObject title_canvas;
    public GameObject explain_canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void To_explain()
    {
        explain_canvas.SetActive(true);
        title_canvas.SetActive(false);
    }
    public void To_title()
    {
        title_canvas.SetActive(true);
        explain_canvas.SetActive(false);
    }
}
