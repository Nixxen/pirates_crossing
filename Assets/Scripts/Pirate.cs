
using UnityEngine;
using UnityEngine.SceneManagement;



public class Pirate : MonoBehaviour
{

    public Rigidbody2D rb;

    public float moveDelay = .5f;

    public AudioSource src;

    public AudioClip jumpSound, death;

    float nextTimeToMove = 0f;

    bool isJumping = true;


    void Start ()
    {
        // 10 second start delay
        nextTimeToMove = Time.time + 10f;
    }



    void Update()
    {

        if (nextTimeToMove <= Time.time)
        {
            nextTimeToMove = Time.time + moveDelay;
            isJumping = false;
            MovementDelay.movementDelay = 0f;
        }
        else if (isJumping)
        {
            MovementDelay.movementDelay = (nextTimeToMove - Time.time);
        
        }

        

        // Movement checks
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Attempt move
            if (!isJumping)
            {
                isJumping = true;
                src.PlayOneShot(jumpSound);
                MovePirate();
            }
                
        }else
        {
            // Debug.Log("You can't move yet!");
        }
    }

    void MovePirate()
    {
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

    

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // If we hit a Minotaur
        if (hitInfo.CompareTag("Minotaur"))
        {
            // Destroy the Minotaur
            Destroy(hitInfo.gameObject);
            // Destroy the Pirate
            Destroy(gameObject);

            Debug.Log("You have been eaten by a Minotaur! Final score = " + Score.scoreValue);
            Score.scoreValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // If we hit a death wall
        else if (hitInfo.CompareTag("DeathWall"))
        {
            src.PlayOneShot(death);
            
            // Destroy the Pirate
            Destroy(gameObject);

            Debug.Log("You have missed the shore and drowned! Final score = " + Score.scoreValue);
            Score.scoreValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (hitInfo.CompareTag("Convoy"))
        {
            // Move the pirate with the convoy
            transform.parent = hitInfo.transform;
        }
    }

    void OnTriggerExit2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Convoy"))
        {
            // Stop moving the pirate with the convoy
            transform.parent = null;
        }
    }


}
