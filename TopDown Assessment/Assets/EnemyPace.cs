using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPace : MonoBehaviour
{
    float timer = 0.0f;
    public Vector2 movedir;
    public float moveSpeed = 5.0f;
    public float pacelength = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        //movedir = new Vector2(1, 0); 
        movedir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > pacelength)
        {
            //do something
            movedir *= -1;
            timer = 0;
        }
        GetComponent<Rigidbody2D>().velocity = movedir * moveSpeed;
            
    }
}
