using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource ClickingButton;
    public AudioSource ClickingButton2;

    public void playButton(){
        ClickingButton2.Play();
    } 

    public void quitButton(){
        ClickingButton.Play();
    } 
}
