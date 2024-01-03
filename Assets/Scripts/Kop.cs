using UnityEngine;
using System.Collections;

public class Kop : MonoBehaviour
{
    public Rigidbody2D ballRigidbody;
    public float kickStrength = 10f;
    public float rotationAngle = 30f;
    private Pozice playerDirection;
    public static bool wasKicked = false;

    void Start()
    {
        playerDirection = GetComponent<Pozice>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(KickBall());
        }
    }

    IEnumerator KickBall()
    {
        wasKicked = true;

        float rotationAngle = 30f; // Nastavte úhel otočení

        // Zjištění směru otočení na základě posledního pohybu
        if (playerDirection.currentDirection == Pozice.Direction.Left)
        {
            rotationAngle = -rotationAngle; // Otočení doleva
        }

        // Otáčení hráče
        transform.Rotate(0, 0, rotationAngle);

        // Krátká pauza
        yield return new WaitForSeconds(0.1f);

        // Odkopnutí míče
        if (ballRigidbody != null)
        {
            Vector2 direction = (ballRigidbody.position - (Vector2)transform.position).normalized;
            ballRigidbody.AddForce(direction * kickStrength, ForceMode2D.Impulse);
        }

        // Vrácení hráče do původní pozice
        transform.Rotate(0, 0, -rotationAngle);

        yield return new WaitForSeconds(0.1f); // Doba, po kterou se považuje míč za kopnutý

        wasKicked = false;
    }

    
}
