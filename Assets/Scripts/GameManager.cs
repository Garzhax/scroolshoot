using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverCanvas; // ← agregamos esta referencia

    public GameObject winCanvas; // ← nueva referencia para el cartel de victoria


    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");

        if (gameOverCanvas != null)
            gameOverCanvas.SetActive(true); // ← mostramos el cartel

        // Opcional: pausar el juego
        Time.timeScale = 0f;
    }

    public void Win()
    {
        Debug.Log("You Win!");

        if (winCanvas != null)
            winCanvas.SetActive(true); // Muestra el cartel

        Time.timeScale = 0f; // Pausar juego (opcional)
    }
    void Update()
    {
        // Condición de victoria: no quedan enemigos
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Win();
        }
    }

}


