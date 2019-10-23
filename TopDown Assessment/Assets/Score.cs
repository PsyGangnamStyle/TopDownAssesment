using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int ScoreCount = 0;
    public Text scoreText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plus")
        {
            ScoreCount++;
            scoreText.text = "Score:" + ScoreCount;
            Destroy(collision.gameObject);
            if (ScoreCount > 20)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}

