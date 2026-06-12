using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;
    public bool juegoTerminado;
    public int score = 0;

    

    // Start is called before the first frame update
    void Start()
    {
         Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        uiManager.UpdateTimer(timer);
         if (timer <= 0)
        {
            juegoTerminado = true;
            uiManager.MostrarPantallaGameOver();
            Time.timeScale = 0;
        }
         if (score == 3)
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
