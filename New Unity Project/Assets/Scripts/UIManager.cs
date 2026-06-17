using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
     public TextMeshProUGUI win;
     public TextMeshProUGUI score;
     public TextMeshProUGUI timer;
     public GameObject winPanel;
     public GameObject gameOverPanel;
     public UIManager uiManager;
     public bool juegoTerminado;
     public int Score = 0;

    public void UpdateScore (int currentScore)
    {
        score.text = "Score: " + currentScore;
    }

    public void UpdateTimer(float currentTime)
    {
        timer.text = "0:" + Mathf.CeilToInt(currentTime).ToString("00");
    }
     public void MostrarPantallaWin()
    {
        winPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        gameOverPanel.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score == 3)
         {
            juegoTerminado = true;
            uiManager.MostrarPantallaWin();
            Time.timeScale = 0;
         }
         if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
