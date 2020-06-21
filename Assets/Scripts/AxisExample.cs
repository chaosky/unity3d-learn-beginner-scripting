using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AxisExample : MonoBehaviour
{
    public float range;
    public TextMeshProUGUI textOutput;

    public Transform target;

    private void Start()
    {
        textOutput.transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        textOutput.text = "Value Returned: <b>" + h.ToString("F2") + "</b>";
        textOutput.transform.LookAt(target);
    }
}
