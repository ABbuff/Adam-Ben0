using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireMeter : MonoBehaviour
{
    public MeterMarker marker;
    public MechControlCode MechanicalController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(marker.getDistanceFromGoal()) >= .05)
        {
            //gameObject.transform.localScale += new Vector3(marker.getDistanceFromGoal() * 5f * Time.deltaTime, 0, 0);
        }
    }
}
