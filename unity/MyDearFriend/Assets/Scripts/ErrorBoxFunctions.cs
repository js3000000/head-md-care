using UnityEngine;
using Yarn.Unity;
using UnityEngine.EventSystems;

public class ErrorBoxFunctions : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public GameObject objectToShow;

    private bool shouldStartWarningOnStartComplete = false;

    [YarnCommand("showWarning")]
    public void ShowWarning()
    {
        if (objectToShow != null)
        {
            foreach (Transform child in objectToShow.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

        if (dialogueRunner != null)
        {
            shouldStartWarningOnStartComplete = true;
            OnNodeComplete("Start");
        }
    }

    private void OnNodeComplete(string completedNodeName)
    {
        if (shouldStartWarningOnStartComplete && completedNodeName == "Start")
        {
            shouldStartWarningOnStartComplete = false;
            dialogueRunner.StartDialogue("WarningWindow");
        }
    }
}
