using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);  // Destruye jugador
            Destroy(gameObject);            // Destruye bala

            // Aqu� pod�s llamar a alg�n m�todo para mostrar Game Over si quer�s
        }
       
    }
    private void OnTriggerEnter( Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);  // Destruye jugador
            Destroy(gameObject);            // Destruye bala

            // Aqu� pod�s llamar a alg�n m�todo para mostrar Game Over si quer�s
        }
       
    }
}
