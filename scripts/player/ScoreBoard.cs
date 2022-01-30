using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    TMP_Text tmp;
     
     int score;
    
    private void Start()
    {
        tmp = GetComponent<TMP_Text>();
        tmp.text = "0 -";
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        var tableScore = score.ToString();
        tmp.text = $"{tableScore} - ";

        if(score == 5)
        {
            SceneManager.LoadScene(1);
        }
    }
   
   
}
