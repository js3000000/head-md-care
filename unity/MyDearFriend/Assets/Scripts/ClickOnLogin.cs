using UnityEngine;
// use event system for click detection
using UnityEngine.EventSystems;
public class ClickOnLogin : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectToActivate;
    public void OnPointerClick(PointerEventData eventData)
    {
        // destroy the parent object of the login button when clicked
        Destroy(transform.parent.gameObject);
        // activate the specified object
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }
}
