using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalscene : MonoBehaviour
{
    public void RestartGame(){

        health.t1 = false;
        health.t2 = false;
        AIDead.a1 = false;
        AIDead.a2 = false;
        p_Randomizer.done = false;
        randomizer.dd = false;
        GameStartTimer.startai = false;
        scorecounter.score = 30;
        scorecounter.score2 = 30;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame(){
        Debug.Log("Game Has Ended");
        Application.Quit();
    }
}
