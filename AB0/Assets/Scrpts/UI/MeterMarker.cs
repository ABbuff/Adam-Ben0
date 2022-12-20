using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterMarker : MonoBehaviour
{
    public MechControlCode mechController;
    private static float startX = -8.4f;
    private static float endX = 8.4f;
    private static float constantY = 6.9f;
    private static float maxScore;
    private static float deltaX;
    private float distanceFromGoal;

    // Start is called before the first frame update
    void Start()
    {
        maxScore = mechController.maxScore;
        deltaX = (endX - startX) / maxScore;
        transform.position = new Vector2(startX, constantY);
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromGoal = gameObject.transform.position.x - ((deltaX * mechController.score) + startX);
        //Debug.Log("Distance Marker Should Move: " + distanceFromGoal);

        if (Math.Abs(distanceFromGoal) >= .05)
        {
            gameObject.transform.position = transform.position - new Vector3(distanceFromGoal * 5f * Time.deltaTime, 0, 0);
        }

    }

    public float getDistanceFromGoal()
    {
        return distanceFromGoal;
    }
}
