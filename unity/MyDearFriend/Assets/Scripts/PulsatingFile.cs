using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class PulsatingFile : MonoBehaviour
{
    public bool canClick = false;

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

    public void OnPointerDown(PointerEventData eventData)
    {
        pulsing = false;
    }
}