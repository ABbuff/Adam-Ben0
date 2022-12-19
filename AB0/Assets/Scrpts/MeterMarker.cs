using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterMarker : MonoBehaviour
{
    public MechControlCode mechController;
    private static float startX = -8.4f;
    private static float endX = 8.4f;
    private static float startY = 6.7f;
    private static float maxScore;
    private static float deltaX;

    // Start is called before the first frame update
    void Start()
    {
        maxScore = mechController.maxScore;
        deltaX = (endX - startX) / maxScore;
        transform.position = new Vector2(startX, startY);
    }

    // Update is called once per frame
    void Update()
    {
        private float distanceFromGoal = gameObject.transform.position.x - (deltaX * mechController.score) + startX);
        if (Math.Abs(distanceFromGoal) <= .05){
            gameObject.transform.position = transform.position + new Vector3((distanceFromGoal*10f*Time.deltaTime), 0, 0);
        }

    }

}
