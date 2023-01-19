using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_planet : MonoBehaviour
{
    public GameObject planet;
    public GameObject cubePusher;
    private int n;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "planet_earth")
        {            
            cubePusher.SetActive(true);
            n = 1;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "planet_earth")
        {
            cubePusher.SetActive(false);
            n = 0;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("planet");
        Debug.Log(planet.transform.position);


        Debug.Log("cube");
        Debug.Log(cubePusher.transform.position);

        if (Input.GetMouseButton(2) && n == 1)
        {
            Vector3 planet_position = planet.transform.position;
            planet_position = Vector3.Lerp(planet.transform.position, transform.position, Time.deltaTime * 30);
            planet.transform.position = planet_position;
        }
    }
}
