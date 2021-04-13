using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Pawn : MonoBehaviour
{

    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Attack()
    {
        // Trigger Animation
        animator.SetTrigger("Attack");
    }
}
