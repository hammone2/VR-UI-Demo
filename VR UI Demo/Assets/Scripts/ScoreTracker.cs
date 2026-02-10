using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int _score = 0;
    public int score
    {
        set
        {
            _score = value;
            scoreText.SetText("Score: " + _score.ToString());
        }

        get { return _score; }
    }

    public static ScoreTracker Instance;

    private void Awake()
    {
        Instance = this;
    }
}
