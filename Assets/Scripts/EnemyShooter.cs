using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootInterval = 2f;
    public float bulletSpeed = 10f;

    private float timer;

    // Referencia al jugador
    private Transform player;

    void Start()
    {
        // Busca al jugador por tag (asegurate de que el jugador tenga el tag "Player")
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
            Debug.Log("a");
        }
    }

    void Update()
    {
        if (player == null) return;

        timer += Time.deltaTime;
        if (timer >= shootInterval)
        {
            Shoot();
            timer = 0;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Dirección hacia el jugador
        Vector3 direction = (player.position - firePoint.position).normalized;
        rb.linearVelocity = direction * bulletSpeed;

    }

}