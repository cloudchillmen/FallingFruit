using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pointCounter;
    public GameObject levesCounter;
    public GameObject gameOver;
    int lives = 3;
    int points = 0;

    public void AddPoint(int amount = 1)
    {
        points += amount;   
    }

    public void LoseLife()
    {
        lives--;
        if(lives == 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        pointCounter.GetComponent<TextMeshProUGUI>().text = "Points: " + points;
        levesCounter.GetComponent<TextMeshProUGUI>().text = "Lives: " + lives;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
