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
        //scoreManager.AddScore(new Score("Test1", "100"));
        //scoreManager.AddScore(new Score("Test2", "200"));

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
