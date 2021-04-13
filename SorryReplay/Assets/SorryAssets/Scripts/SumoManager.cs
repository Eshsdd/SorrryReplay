using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumoManager : MonoBehaviour
{
    public Animator homeAnimator;
    public Animator awayAnimator;
    public Text text;

    public static int PlayerScore = 0;


    private float textOpacity = 0;
    private bool textIsFading = false;

    // Start is called before the first frame update
    void Start()
    {
        homeAnimator.SetTrigger("Fall");
        awayAnimator.SetTrigger("Fall");
    }

    // Update is called once per frame
    void Update()
    {
        if (textIsFading)
        {
            textOpacity = textOpacity - (float).01;
            text.color = new Color(text.color.r, text.color.g, text.color.b, textOpacity);
            if (textOpacity <= 0)
            {
                textIsFading = false;
            }
        }

        if (Input.GetKeyDown("mouse 0"))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Play Attack Animation 
        homeAnimator.SetTrigger("Attack");
        awayAnimator.SetTrigger("Attack");

        PlayerScore++;

        // Update Scoreboard Text
        text.text = PlayerScore.ToString();
        text.transform.position = Input.mousePosition;
        if (text.fontSize < 80)
        {
            text.fontSize = 20 + PlayerScore;
        }
        textOpacity = 1;
        textIsFading = true;
    }
}
