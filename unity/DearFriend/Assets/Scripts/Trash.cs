using UnityEngine;
using Yarn.Unity;

public class Trash : MonoBehaviour
{
    [YarnCommand("throwAway")]
    public void ThrowAway()
    {
        Debug.Log("Trash: Throwing away the item.");
        // Here you can add any logic you want to handle when the item is thrown away.
        // For example, you could disable the object, play a sound, or trigger an animation.
        gameObject.SetActive(false); // This will hide the object in the scene.
    }
}
