using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class State_2p : MonoBehaviour
{
    public int hp;
    public int cost;
    public int cost_pre;
    public int cost_up;
    public int cost_trap;
    public int cost_castle;
    public GameObject hit_eff;
    public AudioClip damage;
    AudioSource audioSource;
    public State_1p script_1p;
    public int power;
    public int castle_hp;
    public int power_s;
    public int castle_hp_s;
    public int explode_s;
    public int explode_power;
    public int care_s;
    public int care;
    public int wall_scale_s;
    public int wall_scale;
    public int trap_castle_s;
    public int trap_castle;
    public int castle_light_power;
    public int trap_light_power;
    public int bomb_light_power;
    public int care_light_power;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > 100)
        {
            hp = 100;
        }
        if (cost_pre >= 5)
        {
            cost_up += 1;
            cost_pre = 0;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("1P_Win");
        }
        if (power_s >= 50)
        {
            power += 10;
            power_s = 0;
            cost_trap += 1;
            trap_light_power += 1;
        }
        if (castle_hp_s >= 50)
        {
            castle_hp += 20;
            castle_hp_s = 0;
            cost_castle += 1;
            castle_light_power += 1;
        }
        if (explode_s >= 50)
        {
            explode_power += 5;
            explode_s = 0;
            cost_trap += 1;
            bomb_light_power += 1;
        }
        if (care_s >= 50)
        {
            care += 5;
            care_s = 0;
            cost_castle += 1;
            care_light_power += 1;
        }
        if (wall_scale_s >= 50)
        {
            wall_scale += 1;
            wall_scale_s = 0;
        }
        if (trap_castle_s >= 100)
        {
            trap_castle += 2;
            trap_castle_s = 0;
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bullet_1p")
        {
            hp -= script_1p.power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
        if (collider.gameObject.tag == "explode_1p")
        {
            hp -= script_1p.explode_power;
            audioSource.PlayOneShot(damage);
            GameObject obj = Instantiate(hit_eff,
                        transform.position,
                        transform.rotation);
            Destroy(obj, 0.2f);
        }
    }
}
