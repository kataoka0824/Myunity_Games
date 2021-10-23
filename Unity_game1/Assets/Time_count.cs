using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_count : MonoBehaviour
{
    public float time_count = 10;
    public GameObject time_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time_count -= Time.deltaTime;
        Text time_text = time_object.GetComponent<Text>();
        time_text.text = "time:" + time_count.ToString();
    }
}
