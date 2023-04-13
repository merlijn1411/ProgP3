using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    //deze moet in de canvas: score 
    private TMP_Text scoreField;
    private int score = 0;

    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        score = 0;  
        scoreField.text = "" + score;
        
    }

    public void AddScore(int scoreScript)
    {
        score += scoreScript;
        scoreField.text = "" + score;
        
    }
}
