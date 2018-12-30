using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // GameManager used to control all the game logic.
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;

    int score = 0;
    int lives = 3;
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

        if ( ! gameOver ) {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void decrementScore() {

        if ( ! gameOver ) {
            score--;
            scoreText.text = score.ToString();
        }
    }

    public void decreaseLife() {
        if ( lives > 0 ) {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive( false );
        }

        if ( lives <= 0 ) {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver() {
        // stop candies being spawned - CandySpawner is a static class.
        CandySpawner.instance.StopSpawningCandies();
        // get the Player GameObject , then access the PlayerControlles component ( which is an script ) and set the public variable canMove to false.
        GameObject.Find( "Player" ).GetComponent<PlayerController>().canMove = false;
        // gameObject gameOver panel is disabled by default, enable it when the game is over.
        gameOverPanel.SetActive( true );
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }
}
