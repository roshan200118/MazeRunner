using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Class to instantiate each row in leaderboard 
public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;

    void Start()
    {
        //Testing
        /*scoreManager.AddScore(new Score("Test1", "0:34:45"));
        scoreManager.AddScore(new Score("Test2", "1:15:15"));
        scoreManager.AddScore(new Score("Test3", "0:59:59"));*/

        //Store the scores
        var scores = scoreManager.GetHighScores().ToArray();

        //For each score, instantiate a row
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.userName.text = scores[i].name;
            row.score.text = scores[i].score;
        }
    }
}
