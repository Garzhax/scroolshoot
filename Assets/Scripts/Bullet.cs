using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);  // Destruye jugador
            Destroy(gameObject);            // Destruye bala

            // Aquí podés llamar a algún método para mostrar Game Over si querés
        }
       
    }
    private void OnTriggerEnter( Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);  // Destruye jugador
            Destroy(gameObject);            // Destruye bala

            // Aquí podés llamar a algún método para mostrar Game Over si querés
        }
       
    }
}
