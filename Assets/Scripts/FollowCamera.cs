using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private void LateUpdate()
    {
        //Vector3 playerToCameraOffset = transform.position + -playerTransform.forward /*+ new Vector3(0, 5, 5)*/;
        transform.position = playerTransform.position + new Vector3(0, 5, -5);
    }
}
