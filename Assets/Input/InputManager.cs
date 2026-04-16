using UnityEngine;

using UnityEngine.InputSystem; 

public class InputManager : MonoBehaviour
{
    public static Vector2 Movement;

    private PlayerInput _playerInput;
    private InputAction _moveAction; // to set this, we need to get reference to that player's input component

    private void Awake() // to grab the reference
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];

    }

    private void Update()
    {
        // this is an action so we want to check for it every frame
        Movement = _moveAction.ReadValue<Vector2>();
    }

}
