using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotateSpeed = 350f; //could be upgraded with pickups!

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.position += (Vector3)movement * speed * Time.deltaTime;


        if (movement != Vector2.zero) { //if theres a movement detected, object will rotate in that direction
            Quaternion doRotate = Quaternion.LookRotation(Vector3.forward, movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, doRotate, rotateSpeed * Time.deltaTime);
        }
    }
}
