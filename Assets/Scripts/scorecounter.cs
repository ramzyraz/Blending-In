using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
    public Text p1;
    public Text p2;

    public Text p1down;
    public Text p2down;

    public static int score = 30;
    public static int score2 = 30;

    // Update is called once per frame
    void Update()
    {
        p1.text = "P1\n" + score;
        p2.text = "P2\n" + score2;

        p1down.text = "P1\n" + score;
        p2down.text = "P2\n" + score2;
    }
}
