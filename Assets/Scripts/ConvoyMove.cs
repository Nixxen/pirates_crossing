
using UnityEngine;

public class ConvoyMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 4f;




    void FixedUpdate()
    {
        // Any direction fix
        Vector2 forward = new Vector2(-transform.up.x, transform.up.y);
        // Move Minotaur
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    
    }
}
