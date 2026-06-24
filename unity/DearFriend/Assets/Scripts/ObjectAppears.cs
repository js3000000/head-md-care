using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;


public class ObjectAppears : MonoBehaviour
{
   public DialogueRunner dialogueRunner;
   public string dialogueNodeName;
   public GameObject objectToActivate;
    
[YarnCommand("activateObject")]
   public void activeateObject()
   {   
        // activate the specified object
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

   }
}