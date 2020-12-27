using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public Animator anim;
    public AudioSource splayer;
    public int HP = 100;

    public static bool t1;
    public static bool t2;
    int currentHP;
    int currentHP2;

    void Start()
    {
        currentHP = HP;
        currentHP2 = HP;
    }

    public void DoDamage(int bonus, int damage)
    {   
        scorecounter.score2 += bonus;           
        currentHP -= damage;
        anim.SetTrigger("Damaged");

        if (currentHP <= 0) {
            Dead();
            t1 = true;
            StartCoroutine(LoadMYScene());
        }
    }

    public void DoDamageP2(int bonus, int damage)
    {   
        scorecounter.score += bonus;
        currentHP2 -= damage;
        anim.SetTrigger("Damaged");

        if (currentHP2 <= 0) {
            Dead();
            t2 = true;
            StartCoroutine(LoadMYScene());
        }
    }

    void Dead(){
        splayer.Play();
        anim.SetBool("DeadBro", true);
        GetComponent<Collider>().enabled = false;
        this.enabled = false;
    }

    IEnumerator LoadMYScene() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
