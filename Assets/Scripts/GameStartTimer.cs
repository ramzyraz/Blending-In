using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartTimer : MonoBehaviour
{
    float cTime;
    [SerializeField] Text Timecounter;
    [SerializeField] float sTime = 5;
    public GameObject toDestroy;
    public static bool startai;

    void Start()
    {
        cTime = sTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (p_Randomizer.done == true && randomizer.dd == true){
            toDestroy.SetActive(true);
            GameObject.FindWithTag("Player").GetComponent<Animator>().enabled = false;
            GameObject.FindWithTag("Player2").GetComponent<Animator>().enabled = false;
            GameObject.FindWithTag("AI").GetComponent<Animator>().enabled = false;
            cTime -= 1 * Time.deltaTime;
            Timecounter.text = cTime.ToString("0");

            if (cTime <= 3){
                Timecounter.color = Color.red;
            }

            if (cTime <= 0) {
                GameStart();
            }
        }
    }

    void GameStart(){
        toDestroy.SetActive(false);
        
        GameObject.FindWithTag("Player").GetComponent<Animator>().enabled = true;
        GameObject.FindWithTag("Player2").GetComponent<Animator>().enabled = true;
        GameObject.FindWithTag("AI").GetComponent<Animator>().enabled = true;
        startai = true;
    }
}
