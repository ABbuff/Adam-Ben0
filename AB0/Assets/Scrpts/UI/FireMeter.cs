using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireMeter : MonoBehaviour
{
    private MeterMarker marker;
    private MechControlCode mechController;
    private GameObject markerObj;
    private float fScore, positionDiff;
    private Vector3 expansion;
    private Renderer visualObject;
    // Start is called before the first frame update
    void Start()
    {
        //finds the Mechanical Controller and the Meter Marker
        marker = GameObject.FindObjectOfType<MeterMarker>();
        mechController = GameObject.FindObjectOfType<MechControlCode>();

        //moves the oject to the pivot is in the perfect spot
        gameObject.transform.localPosition = new Vector3((float)gameObject.GetComponent<Renderer>().bounds.extents.x,0,0);

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
        visualObject = gameObject.GetComponent<Renderer>();

        positionDiff = marker.getXPosition()- (visualObject.bounds.center.x + visualObject.bounds.extents.x);
        if (positionDiff > 0f)
        {
            gameObject.transform.parent.transform.localScale += new Vector3(positionDiff, 0f, 0f);
        }
        
    }
}
