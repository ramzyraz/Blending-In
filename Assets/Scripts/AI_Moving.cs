using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Moving : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (GameStartTimer.startai){
            anim.SetBool("Start_Moving", true);
        }
    }
}
