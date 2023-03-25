
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // If we hit a Pirate
        if (hitInfo.CompareTag("Player"))
        {
            // Destroy the Pirate
            Destroy(hitInfo.gameObject);
            Score.scoreValue += 100;

            Debug.Log("You have escaped the Minotaur!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        }
    }

}
