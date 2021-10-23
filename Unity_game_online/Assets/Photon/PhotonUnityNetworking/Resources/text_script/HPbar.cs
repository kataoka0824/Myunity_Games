using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public State state_script;
    public GameObject hp_bar;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = hp_bar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = state_script.hp;
    }
}
