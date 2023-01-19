using UnityEngine;

public class FollowPlanet : MonoBehaviour
{
    public GameObject[] planets;
    public int selectedPlanetIndex = 0;
    public float followSpeed = 5f;
    public bool follow = false;

    private void Update()
    {
        if (follow)
        {
            // Follow the selected planet
            transform.position = Vector3.Lerp(transform.position, planets[selectedPlanetIndex].transform.position, followSpeed * Time.deltaTime);
            transform.LookAt(planets[selectedPlanetIndex].transform);
        }
    }

    public void OnFollowButtonClick()
    {
        follow = !follow;
    }
}