using UnityEngine;
using TMPro;

public class DialogueStyleByCharacter : MonoBehaviour
{
    public TextMeshProUGUI characterName;
    public RectTransform bubble;

    public Vector2 annaPosition;
    public Vector2 camillePosition;

    public Color annaColor = Color.white;
    public Color camilleColor = Color.white;

    public UnityEngine.UI.Image bubbleImage;

    void LateUpdate()
    {
        if (characterName == null || bubble == null) return;

        string speaker = characterName.text.Trim();

        if (speaker == "Anna")
        {
            bubble.anchoredPosition = annaPosition;
            if (bubbleImage) bubbleImage.color = annaColor;
        }
        else if (speaker == "Camille")
        {
            bubble.anchoredPosition = camillePosition;
            if (bubbleImage) bubbleImage.color = camilleColor;
        }
    }
}