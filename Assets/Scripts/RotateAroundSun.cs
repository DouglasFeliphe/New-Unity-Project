using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    public Transform sunTransform;
    public float orbitSpeed = 1.0f;

    void Update()
    {
        // Rotate the planet around the sun
        transform.RotateAround(sunTransform.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
