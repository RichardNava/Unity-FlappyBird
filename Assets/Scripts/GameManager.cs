using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvasGameOver;
    public GameObject canvasStart;

    void Start()
    {
        canvasStart.SetActive(true);
        Time.timeScale = 0;
    }

    
    void Update()
    {
        
    }

    public void PlayGame()
    {
        canvasStart.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);        
    }
}
