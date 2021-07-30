using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        transform.position = player.position;
    }
}
