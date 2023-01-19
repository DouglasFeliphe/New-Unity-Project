using UnityEngine;
using UnityEngine.EventSystems;

public class DoubleTapSelect : MonoBehaviour, IPointerClickHandler
{
    private float doubleClickStart = 0;
    private float doubleClickDelay = 0.2f;
    public GameObject selectedObject;
    public GameObject visualEffect;

    private void Start()
    {
        visualEffect.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 2)
        {
            if (Time.time - doubleClickStart < doubleClickDelay)
            {
                // Object has been double-tapped, select it
                selectedObject = gameObject;
                //Activate visual effect
                visualEffect.SetActive(true);
            }
            doubleClickStart = Time.time;
        }
    }
}
