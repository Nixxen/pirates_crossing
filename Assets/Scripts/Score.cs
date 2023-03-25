
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        scoreText.text = scoreValue.ToString();
    }
}
