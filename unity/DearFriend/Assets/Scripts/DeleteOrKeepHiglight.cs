using UnityEngine;
using Yarn.Unity;


public class DeleteOrKeepHighlight : MonoBehaviour
{
    public GameObject deleteObject;
    public GameObject keepObject;

    public Material deleteMaterial;
    public Material keepMaterial;

    [YarnCommand("setColor")]
    public void SetColor(string answer)
    {
        if (answer == "delete")
        {
            SetColorOnObject(deleteObject, deleteMaterial);
        }
        else if (answer == "keep")
        {
            SetColorOnObject(keepObject, keepMaterial);
        }
    }

    void SetColorOnObject(GameObject target, Material colorMaterial)
    {
        if (target == null) return;

        // get the renderer component of the target object
        Renderer renderer = target.GetComponent<Renderer>();
        Debug.Log($"Found renderer on {target.name}: {renderer != null}");
        if (renderer != null)        {
            // set the material color
            renderer.material = colorMaterial;  
            Debug.Log($"Set color on {target.name} to {colorMaterial.name}");
        }
    }
}