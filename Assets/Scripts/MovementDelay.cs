
using UnityEngine;
using TMPro;


public class MovementDelay : MonoBehaviour
{
    public static float movementDelay = 0f;
    public TextMeshProUGUI movementDelayText;


    void Start()
    {
        movementDelayText.text = movementDelay.ToString();
    }

    void Update()
    {
        if (movementDelay > 0)
        {
            if (movementDelay.ToString().Length > 3)
                movementDelayText.text = "Jumping: " + movementDelay.ToString().Substring(0, 3);
            else
                movementDelayText.text = "Jumping: " + movementDelay.ToString();
        }
        else
        {
            movementDelayText.text = "";
        }
    
    
    }

}
