using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColor : MonoBehaviour
{
    public Color yellow = new Color(1f, 0.75f, 0.04f);
    public Color green = new Color(0.17f, 0.58f, 0.28f);
    public Color blue = new Color(0.01f, 0.39f, 0.49f);
    public Color red = new Color(0.55f, 0.03f, 0f);

    [SerializeField]
    public static Color playerColor;
    public GameObject homeScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setRed()
    {
        playerColor = red;
        homeScreen.SetActive(false);
    }

    public void setYellow()
    {
        playerColor = yellow;
        homeScreen.SetActive(false);
    }

    public void setGreen()
    {
        playerColor = green;
        homeScreen.SetActive(false);
    }

    public void setBlue()
    {
        playerColor = blue;
        homeScreen.SetActive(false);
    }
}
