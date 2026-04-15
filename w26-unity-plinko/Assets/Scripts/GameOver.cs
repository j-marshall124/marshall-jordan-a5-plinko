using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool isGameOver;
    public GameObject GameOverPanel;

    void Update()
    {
        if (isGameOver == true)
        {
            EndGame();
        }
        else if(isGameOver == false)
        {
            StartGame();
        }          
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
        isGameOver = true;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        isGameOver = false;
    }
}
