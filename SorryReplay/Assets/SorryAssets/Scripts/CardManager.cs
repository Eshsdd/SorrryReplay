using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{

    public GameObject UImanager;
    public GameObject deckOfCards;
    public GameObject returnObject;

    public Button returnButton;
    public Button drawButton;

    private int drawnCode;

    // Start is called before the first frame update
    void Start()
    {
        drawButton.onClick.AddListener(cardRandomizer);
        returnButton.onClick.AddListener(goBack);

    }

    // Update is called once per frame
    void Update()
    {
    }


    void goBack()
    {

        UImanager.SetActive(true);
        deckOfCards.transform.GetChild(drawnCode).gameObject.SetActive(false);
        returnObject.SetActive(false);
        drawnCode = 0;
    }

    void cardRandomizer()
    {

        Debug.Log("Draw Button Pressed");
        float rNum = Random.Range(0, 100);
        UImanager.SetActive(false);
        returnObject.SetActive(true);

        if (rNum <= 11)
        {
            Debug.Log("Card 1");

            UImanager.SetActive(false);
            deckOfCards.transform.GetChild(0).gameObject.SetActive(true);
            drawnCode = 0;

        } else if (rNum > 11 && rNum <= 20)
        {
            Debug.Log("Card 2");

            deckOfCards.transform.GetChild(1).gameObject.SetActive(true);
            drawnCode = 1;

        } else if (rNum > 20 && rNum <= 29)
        {
            Debug.Log("Card 3");

            deckOfCards.transform.GetChild(2).gameObject.SetActive(true);
            drawnCode = 2;

        } else if (rNum > 29 && rNum <= 38)
        {
            Debug.Log("Card 4");

            deckOfCards.transform.GetChild(3).gameObject.SetActive(true);
            drawnCode = 3;

        }
        else if (rNum > 38 && rNum <= 47)
        {
            Debug.Log("Card 5");

            deckOfCards.transform.GetChild(4).gameObject.SetActive(true);
            drawnCode = 4;

        }
        else if (rNum > 47 && rNum <= 56)
        {
            Debug.Log("Card 7");

            deckOfCards.transform.GetChild(5).gameObject.SetActive(true);
            drawnCode = 5;

        }
        else if (rNum > 56 && rNum <= 64)
        {
            Debug.Log("Card 8");

            deckOfCards.transform.GetChild(6).gameObject.SetActive(true);
            drawnCode = 6;

        }
        else if (rNum > 64 && rNum <= 73)
        {
            Debug.Log("Card 10");

            deckOfCards.transform.GetChild(7).gameObject.SetActive(true);
            drawnCode = 7;

        }
        else if (rNum > 73 && rNum <= 82)
        {
            Debug.Log("Card 11");

            deckOfCards.transform.GetChild(8).gameObject.SetActive(true);
            drawnCode = 8;

        }
        else if (rNum > 82 && rNum <= 91)
        {
            Debug.Log("Card 12");

            deckOfCards.transform.GetChild(9).gameObject.SetActive(true);
            drawnCode = 9;

        }
        else if (rNum > 91 && rNum <= 100)
        {
            Debug.Log("Sorry Card!");

            deckOfCards.transform.GetChild(10).gameObject.SetActive(true);
            drawnCode = 10;

        }
    }
}
