using UnityEngine;
using UnityEngine.EventSystems;

public class TouchSelect : MonoBehaviour, IPointerDownHandler
{
    public GameObject selectedObject;
    public GameObject visualEffect;
    private bool isSelected = false;

    private void Start()
    {
        visualEffect.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        selectedObject = gameObject;
        isSelected = !isSelected;
        visualEffect.SetActive(isSelected);
    }
}