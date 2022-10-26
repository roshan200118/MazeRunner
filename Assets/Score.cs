using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Score
{

    public string name;
    public string score;

    public Score(string name, string score)
    {
        this.name = name;
        this.score = score;
    }
}