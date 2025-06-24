using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // Auto-destruye la bala luego de un tiempo
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destruye al enemigo
            Destroy(gameObject);       // Destruye la bala
        }
    }
}
