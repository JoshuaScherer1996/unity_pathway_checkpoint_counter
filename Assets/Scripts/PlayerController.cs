using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private float _horizontalInput;
    private Rigidbody _rb;

    // Gets all important elements at the start of the game.
    private void Start()
    {
        _rb = GetComponent<Rigidbody>(); 
    }

    // Called before the update method to ensure proper physics calculations.
    private void FixedUpdate()
    {
        // Gets horizontal input.
        _horizontalInput = Input.GetAxis("Horizontal");

        // Calculates the new position.
        var newPosition = _rb.position + Vector3.forward * (_horizontalInput * speed * Time.fixedDeltaTime);

        // Moves the box.
        _rb.MovePosition(newPosition);
    }
}
