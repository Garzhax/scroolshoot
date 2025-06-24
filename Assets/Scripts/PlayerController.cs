using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public float moveSpeed = 5f;

    // Este método se llama automáticamente con Send Messages
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        // Movimiento en plano X-Z
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject); // Destruye al jugador
                                 // Llamar al GameManager para terminar el juego
            GameManager.Instance.GameOver();
        }
    }
}
