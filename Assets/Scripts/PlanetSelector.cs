using UnityEngine;
using UnityEngine.EventSystems;

public class PlanetSelector : MonoBehaviour, IPointerDownHandler
{
    public bool isSelected = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isSelected = true;
        Debug.Log("isSelected: "+ isSelected);
    }
}