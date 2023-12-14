using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; //doi tuong ma xe follow
    [SerializeField] private float speed = 0.125f;
    [SerializeField] private Vector3 offset; // khong canh tu camera den muc tieu

    private void LateUpdate()
    {
        //tao mot vi tri moi ma camera di chhuyen toi
        Vector3 newPosition = target.position + offset;
        Vector3 smootdCamera = Vector3.Lerp(transform.position, newPosition, speed * Time.deltaTime);
        //update vi tri
        transform.position = smootdCamera;
    }
}
