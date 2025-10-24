using UnityEngine;
public class SelfRotate : MonoBehaviour
{
    public float degreesPerSecond = 10f;
    void Update()
    {
        transform.Rotate(Vector3.up, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}