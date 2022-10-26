using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Class to store the score data
[Serializable]
public class ScoreData
{
    public List<Score> scores;

    //Constructor
    public ScoreData()
    {
        scores = new List<Score>();
    }
}
