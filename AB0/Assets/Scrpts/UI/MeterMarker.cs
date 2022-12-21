using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterMarker : MonoBehaviour
{
    private MechControlCode mechController;
    private static float startX = -8.4f;
    private static float endX = 8.4f;
    private static float constantY = 6.9f;
    private static float maxScore, deltaX, distanceFromGoal, maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        mechController = GameObject.FindObjectOfType<MechControlCode>();
        maxScore = mechController.maxScore;
        deltaX = (endX - startX) / maxScore;
        transform.position = new Vector2(startX, constantY);
        maxPosition = maxScore * deltaX + startX;
        //Debug.Log("maxPosition: " + maxPosition);
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromGoal = gameObject.transform.position.x - ((deltaX * mechController.score) + startX);
        //Debug.Log("Distance Marker Should Move: " + distanceFromGoal);

        if ((Math.Abs(distanceFromGoal) >= .05) && (gameObject.transform.position.x <= maxPosition))
        {
            gameObject.transform.position = transform.position - new Vector3(distanceFromGoal * 5f * Time.deltaTime, 0, 0);
        }

        Debug.Log(gameObject.transform.position.x);
    }

    public float getDistanceFromGoal()
    {
        return Math.Abs(distanceFromGoal);
    }
    public float getDeltaX()
    {
        return deltaX;
    }
    public bool isNegative(float num)
    {
        return num < 0;
    }
    public float getXPosition()
    {
        return gameObject.transform.position.x;
    }
}
