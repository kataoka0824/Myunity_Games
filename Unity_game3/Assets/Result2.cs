using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result2 : MonoBehaviour
{
    public float score2;
    // Start is called before the first frame update
    void Start()
    {
        score2 = State.Result_score();
    }

    // Update is called once per frame
    void Update()
    {
        Text result_text = this.gameObject.GetComponent<Text>();
        result_text.text = "Score:" + score2.ToString();
    }
}
