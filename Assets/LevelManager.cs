using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject pointCounter;
    int points = 0;

    public void AddPoint(int amount = 1)
    {
        points += amount;
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        pointCounter.GetComponent<TextMeshProUGUI>().text = "Points: " + points;
    }
}
