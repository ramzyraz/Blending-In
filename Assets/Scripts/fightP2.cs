using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightP2 : MonoBehaviour
{
    public Animator anim;
    public AudioSource s1;
    public Transform point;
    public float ranger = 0.5f;
    public LayerMask player;
    public int damage = 100;
    public int plusscore = 70;
    public int minuscore = -10;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)){
            PunchAnimation();
        }
    }

    void PunchAnimation(){
        anim.SetTrigger("Punch");
        Invoke("Punch", 0.2f);
    }

    void Punch(){
        int[] myLayers = player.HasLayers();

        for (int i = 0; i < myLayers.Length; i++){
            if (myLayers[i] == 9){    
                int myMask = 1 << 9;
                Collider[] hitColliders = Physics.OverlapSphere(point.position, ranger, myMask);
                foreach (Collider ply in hitColliders)
                {
                    s1.Play();
                    ply.GetComponent<AIDead>().AIDamaged(minuscore, damage, 2);
                }
            }
            else if (myLayers[i] == 8){
                int myMask = 1 << 8;
                Collider[] hitColliders = Physics.OverlapSphere(point.position, ranger, myMask);
                foreach (Collider ply in hitColliders)
                {
                    s1.Play();
                    ply.GetComponent<health>().DoDamage(plusscore, damage);
                }
            }
        }
    }

    void OnDrawGizmosSelected() {
        if (point == null){
            return;
        }
        Gizmos.DrawWireSphere(point.position, ranger);    
    }
}
