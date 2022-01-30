using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreBoardForEnemy : MonoBehaviour
{
    TMP_Text tpm;
    int enemyscore;
    // Start is called before the first frame update
    void Start()
    {
        tpm = GetComponent<TMP_Text>();
    }

    public void IncreaseScoreEnemy(int enemyScore)
    {
        enemyscore += enemyScore;
        tpm.text = enemyscore.ToString();
        if(enemyscore == 5)
        {
            SceneManager.LoadScene(2);
        }
    }

    
}
