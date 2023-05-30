using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text score_text;
    public int score = 0;
    public void Start()
    {
        score_text.text = score.ToString();
    }

    public void PlusScoreScript()
    {
        score++;
        score_text.text = score.ToString();
    }
}
