using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetText : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject gameOver2;

    void Update(){
        if (health.t1 || AIDead.a1){
            gameOver2.SetActive(true);
        }
        else if (health.t2 || AIDead.a2){
            gameOver.SetActive(true);
        }
    }
}
