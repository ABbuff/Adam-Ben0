using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the camera's viewport bounds in world coordinates
        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraWidth = cameraHeight * Camera.main.aspect;
        float minX = Camera.main.transform.position.x - cameraWidth / 2;
        float maxX = Camera.main.transform.position.x + cameraWidth / 2;
        float minY = Camera.main.transform.position.y - cameraHeight / 2;
        float maxY = Camera.main.transform.position.y + cameraHeight / 2;

        // Clamp the cursor position to the screen bounds
        cursorPos.x = Mathf.Max(cursorPos.x, minX);
        cursorPos.x = Mathf.Min(cursorPos.x, maxX);
        cursorPos.y = Mathf.Max(cursorPos.y, minY);
        cursorPos.y = Mathf.Min(cursorPos.y, maxY);
  
        // Move the game object towards the clamped cursor position
        transform.position = Vector3.MoveTowards(transform.position, cursorPos, speed * Time.deltaTime);
    }
}


/*  Another way to do this (USING Mathf.Clamp)
 *  
     public float speed;

    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector3.MoveTowards(transform.position, cursorPos, speed * Time.deltaTime);

        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        screenPos.x = Mathf.Clamp(screenPos.x, 0, Screen.width);
        screenPos.y = Mathf.Clamp(screenPos.y, 0, Screen.height);
        transform.position = Camera.main.ScreenToWorldPoint(screenPos);
    }
}
 */