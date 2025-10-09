using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float zOffset = -7f;  // Distance behind player
    [SerializeField] private float yOffset = 3f;   // Camera height

    private float fixedX; // Camera X position stays constant

    private void Start()
    {
        fixedX = transform.position.x; // Store initial X
    }

    private void LateUpdate()
    {
        if (target == null) return;

        // Only Z and Y follow the player; X stays fixed
        Vector3 newPos = new Vector3(fixedX, yOffset, target.position.z + zOffset);
        transform.position = newPos;

        // Keep camera looking straight forward (no rotation)
        transform.rotation = Quaternion.Euler(20f, 0f, 0f); // Optional fixed angle
    }
}
