using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_light_1p : MonoBehaviour
{
    public GameObject castle_light;
    public int light_range;
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lt.range = light_range;
    }
}
