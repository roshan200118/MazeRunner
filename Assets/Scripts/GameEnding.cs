using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//Class to handle activities when game ends
public class GameEnding : MonoBehaviour
{
    public GameObject player;

    //Used to fade completetion screen after game done
    public CanvasGroup exitBackgroundImageCanvasGroup;

    //Canvas that shows the time
    public Canvas timerCanvas;

    //Text that shows the score on FaderCanvas
    public TextMeshProUGUI scoreText;

    //Inpute field on FaderCanvas
    public GameObject nameInputField;

    //Score manager to manage score
    public ScoreManager scoreManager;

    //Used to handle fade effects
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;

    bool isPlayerAtExit;

    //Timer for fade effects
    float timer;
    string score;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerAtExit)
        {
            ShowWinScreenFade();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerAtExit = true;
            score = timerCanvas.GetComponentInChildren<TextMeshProUGUI>().text;
            print(score);
            scoreText.text = "Score: " + score;
            timerCanvas.gameObject.SetActive(false);
        }
    }

    //Method when Player wins the game, fade out and show completion screen
    void ShowWinScreenFade()
    {
        timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = timer / fadeDuration;

        if (timer > fadeDuration + displayImageDuration)
        {
            //Let the cursor show again
            Cursor.lockState = CursorLockMode.None;
        }
    }

    //Method to save score 
    public void SaveScoreToLeaderboard()
    {
        string name = nameInputField.GetComponent<TMP_InputField>().text;
        scoreManager.AddScore(new Score(name, score));
    }
}
