using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class PulsatingFile : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    //public string clickNodeName;

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

    // void OnNodeComplete(string nodeName)
    // {
    //     if (nodeName == clickNodeName)
    //         pulsing = true;
    // }

    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     Destroy(transform.parent.gameObject);
    //     //start the node specified in clickNodeName
    //     if (dialogueRunner != null && !string.IsNullOrEmpty(clickNodeName))
    //     {
    //         dialogueRunner.StartDialogue(clickNodeName);
    //     }
    // }
}