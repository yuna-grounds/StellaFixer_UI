using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyLight : MonoBehaviour
{
    private GameObject[] lightObjects;
    public Color startColors;
    public Color endColors;
    public float duration;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        lightObjects = GameObject.FindGameObjectsWithTag("Light");
        startTime = Time.time;
        //for (int i = 0; i < lightObjects.Length; i++)
        //{
        //    lightObjects[i].GetComponent<Light>().intensity = 3f;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        float timePassed = Time.time - startTime;
        float percentageComplete = timePassed / duration;
        Color[] currentColors = new Color[lightObjects.Length];
        for (int i = 0; i < lightObjects.Length; i++)
        {
            currentColors[i] = Color.Lerp(startColors, endColors, percentageComplete);
            lightObjects[i].GetComponent<Light>().color = currentColors[i];
        }

        if (percentageComplete >= (duration / 2f))
        {
            // Swap startColors and endColors arrays
            Color temp = startColors;
            startColors = endColors;
            endColors = temp;
            startTime = Time.time;
        }
    }
}
