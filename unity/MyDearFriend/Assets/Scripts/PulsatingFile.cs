using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class PulsatingFile : MonoBehaviour, IPointerClickHandler
{
    public DialogueRunner dialogueRunner;
    public string clickNodeName;

    public GameObject openedFile; 

    public float pulseAmount = 0.1f;
    public float pulseSpeed = 3f;

    Vector3 originalScale;
    bool pulsing = false;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (!pulsing) return;

        // Smoothly goes from 1.0 to 1.1 and back
        float scale = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;

        transform.localScale = originalScale * scale;
    }

    [YarnCommand("startPulsatingFile")]
    public void pulsatingButton()
    {
        pulsing = true;
    }

    [YarnCommand("stopPulsatingFile")]
    public void stopPulsating()
    {
        pulsing = false;
        transform.localScale = originalScale; // Reset to original scale when stopping
    }

    void OnNodeComplete(string nodeName)
    {
        if (nodeName == clickNodeName)
            pulsing = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pulsing = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Destroy(transform.parent.gameObject);
        //start the node specified in clickNodeName
        Debug.Log("PulsatingFile: OnPointerClick received, starting dialogue if applicable.");
        pulsing = false; // Stop pulsating when clicked
        
        if(openedFile != null)
        {
            Debug.Log($"PulsatingFile: Opened file {openedFile} clicked.");
            openedFile.SetActive(true); // Show the opened file
            
        }

        if (dialogueRunner != null && !string.IsNullOrEmpty(clickNodeName))
        {
            dialogueRunner.StartDialogue(clickNodeName);
        }
    }
}