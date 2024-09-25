using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public uint currentScore;
    public TMPro.TMP_Text scoreText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + currentScore.ToString());
        if(currentScore >= 200)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
