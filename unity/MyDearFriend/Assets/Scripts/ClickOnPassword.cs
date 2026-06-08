using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;


public class ClickOnPassword : MonoBehaviour, IPointerDownHandler
{
   public DialogueRunner dialogueRunner;
   public string dialogueNodeName;
   public GameObject objectToActivate;
   public GameObject objectToActivate2;


   public void OnPointerDown(PointerEventData eventData)
   {
       if (dialogueRunner != null && !dialogueRunner.IsDialogueRunning)
       {
           dialogueRunner.StartDialogue(dialogueNodeName);
       }
       // destroy the parent object of the login button when clicked
        Destroy(transform.parent.gameObject);
        // activate the specified object
        if (objectToActivate != null && objectToActivate2 != null)
        {
            objectToActivate.SetActive(true);
            //objectToActivate2.SetActive(true);
        }

   }
}