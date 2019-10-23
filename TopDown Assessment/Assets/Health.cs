using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public int health = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                SceneManager.LoadScene("SampleScene");
            }
                

            
        }
    }

}
