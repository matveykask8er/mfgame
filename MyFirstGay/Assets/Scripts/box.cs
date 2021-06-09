using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class box : MonoBehaviour
{
    public int Score = 0;
    public GameObject ScoreText;
    public void killBox()
    {
        Destroy(gameObject);

    }
    
    public void Count()
    {
        Score++;
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
    }
}
