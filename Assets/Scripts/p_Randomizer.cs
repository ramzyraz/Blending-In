using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_Randomizer : MonoBehaviour
{
    public GameObject[] ai;
    float x1;
    float y1;
    float z1;
    float x2;
    float y2;
    float z2;
    public static bool done;

    void Awake()
    {
        Vector3 position = Vector3.zero; 

        x1 = 24.5f;
        y1 = 0.1f;
        z1 = 12.8f;

        x2 = -19.4f;
        y2 = 0.1f;
        z2 = -30.3f;

        Instantiate(ai[0], new Vector3(x1,y1,z1), Quaternion.identity);
        Instantiate(ai[1], new Vector3(x2,y2,z2), Quaternion.identity);
        done = true;
    }
}
