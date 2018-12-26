using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // GameManager used to control all the game logic.
    public static GameManager instance;

    int score = 0;
    bool gameOver = false;

    public Text scoreText;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore() {
        score++;
        scoreText.text = score.ToString();
    }

    public void decrementScore() {
        score--;
        scoreText.text = score.ToString();
    }
}
