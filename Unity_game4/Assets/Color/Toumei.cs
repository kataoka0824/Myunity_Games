using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toumei : MonoBehaviour
{
    MeshRenderer mr;
    public byte param;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.material.color = mr.material.color - new Color32(0, 0, 0, param);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
