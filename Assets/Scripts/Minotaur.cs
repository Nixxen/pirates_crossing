
using UnityEngine;

public class Minotaur : MonoBehaviour
{

    public Rigidbody2D rb;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

        // Destroy Minotaur after 10 seconds
        Destroy(gameObject, 10f);
    
    }



    void FixedUpdate()
    {
        // Any direction fix
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        // Move Minotaur
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    
    }
}
