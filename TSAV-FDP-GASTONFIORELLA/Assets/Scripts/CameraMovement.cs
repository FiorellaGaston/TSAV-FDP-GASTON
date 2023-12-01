using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;

    float sensitivity = 100;

    Vector2 rotation = Vector2.zero;

    public float yRotationMinumum = -65;
    public float yRotationMaximum = 65;


    void Update()
    {
        rotation.x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        rotation.y -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotation.y = Mathf.Clamp(rotation.y, yRotationMinumum, yRotationMaximum);




        player.Rotate(player.up * rotation.x);

        transform.localRotation = Quaternion.Euler(rotation.y, 0, 0);

    }
}