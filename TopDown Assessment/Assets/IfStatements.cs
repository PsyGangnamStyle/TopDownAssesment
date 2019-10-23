using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotLimit = 180.0f;
    float coldLimit = 110.0f;

    
        
    

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();

        }
    }
    void TemperatureTest()
    {
        if(coffeeTemp > hotLimit)
        {
            Debug.Log("Like zoinks scoob! I've like, burnt my tongue");

        }
        else if(coffeeTemp < coldLimit)
        {
            Debug.Log("Cyka Blyat, this coffee not gud");

        }
        else
        {
            Debug.Log("MmmMmMmM Deliscious Beveraagee");
        }
    }
}
