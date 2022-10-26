using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Manages the score operations
public class ScoreManager : MonoBehaviour
{
    public List<Score> scores;
    private ScoreData scoreData;

    private void Awake()
    {
        //Testing
        //PlayerPrefs.DeleteAll();

        //Get a JSON of the scores
        var json = PlayerPrefs.GetString("scores", "{}");

        //Store it into ScoreData
        scoreData = JsonUtility.FromJson<ScoreData>(json);
    }

    //Method to get the scores from ScoreData and order by highest score (shortest time)
    public IEnumerable<Score> GetHighScores()
    {
        return scoreData.scores.OrderBy(x => x.score);
    }

    //Method to add a score
    public void AddScore(Score score)
    {
        scoreData.scores.Add(score);
    }

    //Save the scores onDestory
    private void OnDestroy()
    {
        SaveScore();
    }

    //Method to save the scores
    public void SaveScore()
    {
        //Get JSON of score data 
        var json = JsonUtility.ToJson(scoreData);

        //Save it locally
        PlayerPrefs.SetString("scores", json);
    }
}
