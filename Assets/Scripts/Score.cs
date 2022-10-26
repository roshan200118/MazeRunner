using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Class to define the Score domain
[Serializable]
public class Score
{
    public string name;
    public string score;

    //Constructor
    public Score(string name, string score)
    {
        this.name = name;
        this.score = score;
    }
}
