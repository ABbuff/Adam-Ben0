using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireMeter : MonoBehaviour
{
    private MeterMarker marker;
    private MechControlCode mechController;
    private GameObject markerObj;
    private float fScore;
    private Vector3 expansion;
    // Start is called before the first frame update
    void Start()
    {
        marker = GameObject.FindObjectOfType<MeterMarker>();
        mechController = GameObject.FindObjectOfType<MechControlCode>();
        markerObj = GameObject.FindWithTag("Marker");
    }

    // Update is called once per frame
    void Update()
    {
        //Collision method
        /*
        if(){

        }
        */

        // Non-collision Mehtod
        /*
        if (Math.Abs(marker.getDistanceFromGoal()) >= .05)
        {
            expansion = new Vector3(5f, 0f, 0f);
            gameObject.transform.parent.transform.localScale += expansion;
            gameObject.transform.localPosition = new Vector3(0.15f,0f,0f);
        }
        */
    }
}
