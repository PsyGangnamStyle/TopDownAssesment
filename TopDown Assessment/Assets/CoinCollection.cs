using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CoinCollection : MonoBehaviour
{
    public int Score = 1;
    public Text scoreText;

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plus")
        {
            Score++;
            Destroy(collision.gameObject);
            if (Score > 9)
            {
                SceneManager.LoadScene("Win");
            }
        }
        if (collision.gameObject.tag == "Minus")
        {
            Score--;
            if (Score < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                SceneManager.LoadScene("eBicLevel");
            }
        }
      }
}
