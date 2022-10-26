using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    private ScoreData scoreData;

    public List<Score> scores;


    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        var json = PlayerPrefs.GetString("scores", "{}");
        scoreData = JsonUtility.FromJson<ScoreData>(json);
    }

    public IEnumerable<Score> GetHighScores()
    {
        return scoreData.scores.OrderBy(x => x.score);
        //scoreData.scores.OrderBy
    }

    public void AddScore(Score score)
    {
        scoreData.scores.Add(score);
    }

    private void OnDestroy()
    {
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(scoreData);
        PlayerPrefs.SetString("scores", json);
    }

}
