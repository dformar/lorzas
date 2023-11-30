using UnityEngine;

public class MinimapMovement : MonoBehaviour
{
    public Transform playerPosition;

    void LateUpdate()
    {
        Vector3 newPosition = playerPosition.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
