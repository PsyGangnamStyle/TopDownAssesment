using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour
{
    public int health = 5;
    public Text healthText;
    public Slider healthSlider;
    public int lives;

    private void Start()
    {
        healthText.text = "HP:" + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        lives = PlayerPrefs.GetInt("Lives");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "HP:" + health;
            healthSlider.value = health;
            if (health < 1)
            {
                if (lives > 0)
                {
                    //we should be dead, right?
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    SceneManager.LoadScene("Victory");
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
}


