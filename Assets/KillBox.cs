using UnityEngine;

public class KillBox : MonoBehaviour
{
    LevelManager levelManager;
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        levelManager.LoseLife();
    }
}
