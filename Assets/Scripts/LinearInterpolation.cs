using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        // In this case, result = 4
        float result = Mathf.Lerp(3f, 5f, 0.5f);
        Debug.Log("result :" + result);

        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);
        // Here result = (4, 5, 6)
        Vector3 v3result = Vector3.Lerp(from, to, 0.75f);
        Debug.Log("vector lerp ret: " + v3result);

        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f);
        float time = Time.deltaTime;
        if (time > 0.02)
        {
            return;
        }
        myLight.intensity = Mathf.Lerp(myLight.intensity, 8f, 0.5f * time);
        if (myLight.intensity < 7.9f)
        {
            Debug.Log("light intensity: " + myLight.intensity + " time: " + time);
        }
    }
}
