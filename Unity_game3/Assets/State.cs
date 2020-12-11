using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public int mode;
    public int bomb_re;
    public int pbomb_re;
    public int rocket_re;
    public int hp;
    public int kill;
    public int kill_target;
    public int score;
    public GameObject goal;
    public float timer1 = 0;
    public static float result_time;
    public static int result_score;
    public static int result_bomb_re=10;
    public static int result_pbomb_re=5;
    public static int result_rocket_re=2;
    public static int result_hp=200;
    // Start is called before the first frame update
    void Start()
    {
        
        bomb_re = result_bomb_re;
        pbomb_re = result_pbomb_re;
        rocket_re = result_rocket_re;
        timer1 = result_time;
        score = result_score;
        hp = result_hp;
        mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.B))
        {
            mode = 0;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            mode = 1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            mode = 2;
        }
        if (kill == kill_target)
        {
            goal.SetActive(true);
        }
        result_time = timer1;
        result_bomb_re = bomb_re;
        result_pbomb_re = pbomb_re;
        result_rocket_re = rocket_re;
        result_score = score;
        result_hp=hp;
    }
    public static float Result_time()
    {
        return result_time;
    }
    public static int Result_score()
    {
        return result_score;
    }
}
