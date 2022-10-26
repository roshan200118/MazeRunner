using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class ScoreUI : MonoBehaviour
{

    public RowUI rowUI;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager.AddScore(new Score("Test1", "0:34:45"));
        scoreManager.AddScore(new Score("Test2", "1:15:15"));
        scoreManager.AddScore(new Score("Test3", "0:59:59"));


        var scores = scoreManager.GetHighScores().ToArray();

        for(int i = 0; i<scores.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.userName.text = scores[i].name;
            row.score.text = scores[i].score;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
