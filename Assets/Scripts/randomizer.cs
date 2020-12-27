using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject ai;
    public int totalai = 10;
    public float radius = 3f;

    float x;
    float y;
    float z;
    int attempts = 10;
    public static bool dd;

    void Awake()
    {
        for (int i = 0; i < totalai; i++)
        {
            Vector3 position = Vector3.zero; 
            bool validPosition = false;
            int spawnAttempts = 0;

            x = Random.Range(-50.0f, 50.0f);
            y = 0;
            z = Random.Range(-50.0f, 50.0f);

            while(!validPosition && spawnAttempts < attempts)
            {
                spawnAttempts++;
                position = new Vector3(x, y, z);
                validPosition = true;
                Collider[] colliders = Physics.OverlapSphere(position, radius);

                foreach(Collider col in colliders)
                {
                    if(col.tag == "AI" || col.tag == "Player" || col.tag == "Player2" || col.tag == "Trees" || col.tag == "Rocks" 
                    || col.tag == "Bush" || col.tag == "Border")
                    {
                        validPosition = false;
                    }
                }
            }

            if(validPosition)
            {
                Instantiate(ai, position + ai.transform.position, Quaternion.identity);
            }
        }
        dd = true;
    }
}
