using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        State.result_hp = 200;
        State.result_time = 0;
        State.result_score = 0;
        State.result_bomb_re = 10;
        State.result_pbomb_re = 5;
        State.result_rocket_re = 3;
        SceneManager.LoadScene("Game");
    }
}
