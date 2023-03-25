
using UnityEngine;

public class ShipSafe : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 5f;

    


    void FixedUpdate()
    {
        // Any direction fix
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        // Move Minotaur
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    
    }
}
