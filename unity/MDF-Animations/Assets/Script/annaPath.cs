using UnityEngine;

public class WalkToTarget : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 2f;

    private void Start()
    {
        transform.position = startPoint.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            endPoint.position,
            speed * Time.deltaTime
        );

        transform.LookAt(endPoint);
    }
}