using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
     public TextMeshProUGUI score;
     public TextMeshProUGUI timer;

    public void UpdateScore (int currentScore)
    {
        score.text = "Score: " + currentScore;
    }

    public void UpdateTimer(float currentTime)
    {
        timer.text = "0:" + Mathf.CeilToInt(currentTime).ToString("00");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
