using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    private MechControlCode mechController;
    public double timer;
    public int secs, mins;
    public int maxSeconds = 90;
    // Start is called before the first frame update
    void Start()
    {
        mechController = GameObject.FindObjectOfType<MechControlCode>();
        secs = 0;
        mins = 0;
        timer = 0.0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        secs = (int)(timer % 60);
        mins = (int)Math.Floor((double)timer / (double)60.0);
        if(timer >= maxSeconds)
        {
            mechController.outOfTime();
        }
    }
}
