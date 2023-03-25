
using UnityEngine;

public class Pirate : MonoBehaviour
{

    public Rigidbody2D rb;

    void Update()
    {

        // Movement checks  
        // Jump right one unit, discrete
        if (Input.GetKeyDown(KeyCode.RightArrow))   
            rb.MovePosition(rb.position + Vector2.right);
        // Jump left one unit
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        // Jump up one unit
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        // Jump down one unit
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }
}
