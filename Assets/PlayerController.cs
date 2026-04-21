using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{   
    public float moveSpeed = 20f;
    Vector2 inputVector;
    GameObject levelManager;
    void Start()
    {
        levelManager = GameObject.Find("LevelManager");
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.y = 0;
        transform.Translate(inputVector * Time.deltaTime * moveSpeed);
    }

    void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector2>();
        //Debug.Log("Move input: " + inputVector);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        levelManager.GetComponent<LevelManager>().AddPoint();
    }
}
