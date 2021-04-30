using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Pawn : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = PlayerColor.playerColor;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
