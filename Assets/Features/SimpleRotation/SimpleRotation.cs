using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] private float angularVelocity = -12.0f;
    [SerializeField] private Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        transform.Rotate(rotationAxis, angularVelocity * Time.deltaTime);
    }
}
