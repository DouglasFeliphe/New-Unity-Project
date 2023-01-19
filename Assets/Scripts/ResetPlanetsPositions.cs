using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlanetsPositions : MonoBehaviour
{
    public GameObject[] planets;
    public Vector3[] originalPositions;

    private void Start()
    {
        // Store the original positions of the planets
        originalPositions = new Vector3[planets.Length];
        for (int i = 0; i < planets.Length; i++)
        {
            originalPositions[i] = planets[i].transform.position;
        }
    }

    public void OnResetButtonClick()
    {
        // Reset the position of all planets to their original positions
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].transform.position = originalPositions[i];
        }
    }
}
