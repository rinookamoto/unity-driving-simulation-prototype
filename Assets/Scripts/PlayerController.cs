using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in inspector)
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;

    // Input System action exposed in inspector for binding
    public InputAction MoveAction;

    private Vector2 moveInput;

    void OnEnable()
    {
        MoveAction.Enable();
    }

    void OnDisable()
    {
        MoveAction.Disable();
    }

    void Update()
    {
        // Read the 2D vector from the MoveAction
        moveInput = MoveAction.ReadValue<Vector2>();

        // Move forward/back along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate around local Y(yaw) using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}