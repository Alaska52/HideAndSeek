using UnityEngine;

// reads input value to determine what to do with the values
public class PlayerController : MonoBehaviour
{
    private PlayerMovement controls;
    private void Awake()
    {
        // initialise our controls
        controls = new PlayerMovement();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}