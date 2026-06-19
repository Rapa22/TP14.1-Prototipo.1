using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveArea : MonoBehaviour
{
    public int score = 0;
    public bool juegoTerminado;
    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            uiManager.UpdateScore(score);
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
