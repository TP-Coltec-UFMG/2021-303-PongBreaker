using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;

    private void Update()
    {
        scoreText.text = score.ToString("0");
    }
}
