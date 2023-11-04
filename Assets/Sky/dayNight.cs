using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class dayNight : MonoBehaviour
{
    [SerializeField] private Transform directionalLight;
    [SerializeField] [Tooltip("Duração do dia em segundos")] private int dayLength;
    [SerializeField] private TextMeshProUGUI timeText;

    private float seconds;
    private float multiplier;


    // Start is called before the first frame update
    void Start()
    {
        multiplier = 86400 / dayLength;
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime * multiplier;

        if(seconds >= 86400)
        {
            seconds = 0;
        }

        processSky();
        calcTime();
    }

    private void processSky()
    {
        float rotX = Mathf.Lerp(-90, 270, seconds / 86400);
        directionalLight.rotation = Quaternion.Euler(rotX, 0, 0);
    }

    private void calcTime()
    {
        timeText.text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm");
    }
}
