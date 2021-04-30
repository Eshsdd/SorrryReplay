using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Buttons
    public Button battleButton;

    public GameObject sumoManager;

    // Start is called before the first frame update
    void Start()
    {
        battleButton.onClick.AddListener(beginBattle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void beginBattle()
    {
        Debug.Log("Battle Button Pressed");
        sumoManager.SetActive(true);
        sumoManager.GetComponent<SumoManager>().Setup();
        sumoManager.GetComponent<SumoManager>().playingSumo = true;
        Debug.Log(sumoManager.GetComponent<SumoManager>().playingSumo);
    }
}
