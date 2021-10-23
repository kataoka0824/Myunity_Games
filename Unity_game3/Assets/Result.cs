using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    //public State state_script;
    public float time2;
    // Start is called before the first frame update
    void Start()
    {
        time2 = State.Result_time();
    }

    // Update is called once per frame
    void Update()
    {
        Text result_text = this.gameObject.GetComponent<Text>();
        result_text.text = "Time:" + time2.ToString();
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Title");
    }
}
