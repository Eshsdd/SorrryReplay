using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumoManager : MonoBehaviour
{
    //insertables
    public Animator homeAnimator;
    public Animator awayAnimator;
    public Text textScore;
    public Text textTimer;
    public GameObject markerObject;
    public GameObject PawnHolder;
    public GameObject UImanager;
    public GameObject returnObject;


    //time
    private float timeStart;
    private float timeReset;
    private float timeEnd;
    private bool timerOn = false;

    //scoring
    public static int PlayerScore = 0;
    private float textOpacity = 0;
    private bool textIsFading = false;
    private bool maxScore = false;
    public Button returnButton;
    public bool playingSumo = false;

    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {

        homeAnimator.SetTrigger("Fall");
        awayAnimator.SetTrigger("Fall");
        returnButton.onClick.AddListener(goBack);
    }

    // Update is called once per frame
    void Update()
    {
        if(playingSumo) { 
        spinMeRightRound();

            

        if (textIsFading)
        {
            textOpacity = textOpacity - (float).01;
            textScore.color = new Color(textScore.color.r, textScore.color.g, textScore.color.b, textOpacity);
            if (textOpacity <= 0)
            {
                textIsFading = false;
            }
        }



        if (Input.GetKeyDown("mouse 0"))
        {
                if (maxScore == false)
                {
                    Attack();

                }
        }
        }
    }


    public void Setup()
    {

        PawnHolder.SetActive(true);
        UImanager.SetActive(false);

        Debug.Log("Setup good " + playingSumo);

    }

    void goBack()
    {

        PawnHolder.SetActive(false);
        UImanager.SetActive(true);
        markerObject.SetActive(false);
        textScore.color = new Color(textScore.color.r, textScore.color.g, textScore.color.b, 0);
        PlayerScore = 0;
        maxScore = false;
        playingSumo = false;
    }


    void Attack()
    {
        if(timerOn == false)
        {
            startTimer();
        }

        // Play Attack Animation 
        homeAnimator.SetTrigger(getRandomAnimation());
        
        awayAnimator.SetTrigger(getRandomAnimation());

        PlayerScore++;

        // Update Scoreboard Text
        textScore.text = PlayerScore.ToString();
        textScore.transform.position = Input.mousePosition;
        if (textScore.fontSize < 80)
        {
            textScore.fontSize = 20 + PlayerScore;
        }
        textOpacity = 1;
        textIsFading = true;


        Debug.Log("Current Score: " + PlayerScore);

        if (PlayerScore == 100)
        {
            scoreTimer();
            //insert fancy end UI elements here


            //after the UI is done
            maxScore = true;
            Debug.Log("MAX SCORE!!!");
            Debug.Log("MAX SCORE!!!");
            Debug.Log("MAX SCORE!!!");
            textScore.text = "MAX SCORE!!!";
        }
    }

    string getRandomAnimation()
    {
        switch (rnd.Next(0,3))
        {
            case 0:
                return ("Attack");
            case 1:
                return ("Attack02");
            case 2:
                return ("Attack03");
        }
        return null;
    }

    void pawnDie()
    {
        awayAnimator.SetTrigger("Die");
    }

    void spinMeRightRound()
    {
       PawnHolder.transform.Rotate(0.0f, 0.5f, 0.0f, Space.Self);
    }

    void startTimer()
    {
        //very specific order of times
        timeStart = Time.time;
        timeReset = 0;
        timerOn = true;

    }
    void scoreTimer()
    {
        markerObject.SetActive(true);
        returnObject.SetActive(true);
        timeEnd = timeReset + (Time.time - timeStart);
        int minutes = (int)timeEnd / 60;
        int seconds = (int)timeEnd % 60;
        int fraction = (int)(Mathf.Floor((timeEnd - (seconds + minutes * 60)) * 100));

        //add into a text thing, I haven't made yet.
        textTimer.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
    }
}
