using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public bool isHighScore;
    float highScore;

    TMP_Text uiText;

    void Start()
    {
        uiText = GetComponent<TMP_Text>();
        if(isHighScore)
        {
            highScore = PlayerPrefs.GetFloat("Score");
            uiText.text = highScore.ToString("F0");
        }
    }

    
    void LateUpdate()
    {
        if (!GameManager.isLive)
            return;
        if (isHighScore && GameManager.score > highScore)
            return;
        uiText.text = GameManager.score.ToString("F0");
    }
}
