using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public int point = 0;
    public GameObject score_object;
    public static int result_score;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text score_text= score_object.GetComponent<Text>();
        score_text.text = "score:"+point.ToString();
        result_score = point;
    }
    public static int def_point()
    {
        return result_score;
    }
}
