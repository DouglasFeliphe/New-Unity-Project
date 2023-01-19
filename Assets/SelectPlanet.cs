using UnityEngine;
using Vuforia;

public class SelectPlanet : MonoBehaviour, IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour Vb;
    public GameObject[] planets;
    private int selectedPlanetIndex = -1;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("SelectPlanet OnButtonPressed");
        // Increase the selected planet index
        selectedPlanetIndex++;

        // Check if the index is out of bounds
        if (selectedPlanetIndex >= planets.Length)
        {
            selectedPlanetIndex = 0;
        }

        // Deactivate all planets
        foreach (var planet in planets)
        {
            planet.SetActive(false);
        }

        // Activate the selected planet
        planets[selectedPlanetIndex].SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("SelectPlanet OnButtonReleased");
    }
}