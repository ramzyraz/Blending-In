using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIDead : MonoBehaviour
{
    public Animator anim;
    public GameObject sounder;
    public AudioSource splayer;
    int AIHP;

    public static bool a1;
    public static bool a2;

    void Start() {
        AIHP = 100;    
    }
    public void AIDamaged(int bonus, int damage, int p){
        if (p == 1){
            scorecounter.score += bonus;
        }
        else if (p == 2){
            scorecounter.score2 += bonus;
        }

        AIHP -= damage;
        anim.SetTrigger("AIDamaged");
        if (AIHP <= 0) {
            ADead();
        }

        if (scorecounter.score <= 0) {
            a1 = true;
            StartCoroutine(LoadMYScene());
        }
        
        if (scorecounter.score2 <= 0) {
            a2 = true;
            StartCoroutine(LoadMYScene());
        }            
    }
    public void ADead(){
        sounder.SetActive(true);
        splayer.Play();
        anim.SetBool("AIdead", true);
        GetComponent<Collider>().enabled = false;
        this.enabled = false;
    }

    IEnumerator LoadMYScene() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
