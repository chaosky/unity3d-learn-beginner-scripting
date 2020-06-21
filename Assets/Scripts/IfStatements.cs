using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("coffee is too hot. Temperature: " + coffeeTemperature + " deltaTime: " + Time.deltaTime);
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("coffee is too cold. Temperature: " + coffeeTemperature + " deltaTime: " + Time.deltaTime);
        }
        else
        {
            print("coffee is just right. Temperature: " + coffeeTemperature + " deltaTime: " + Time.deltaTime);
        }
    }
}
