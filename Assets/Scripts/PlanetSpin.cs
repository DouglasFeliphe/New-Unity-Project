using UnityEngine;
using System.Collections;

public class PlanetSpin : MonoBehaviour {
    public float speed = 10f;
    public bool isSelected = false;

    void Update() {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}