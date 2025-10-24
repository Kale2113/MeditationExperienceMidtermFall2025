using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int speed;
    public bool rotate = false; // controls rotation

    void Start()
    {
        if (target == null)
            target = this.transform; // default to self
    }

    void Update()
    {
        if (!rotate) return; // only rotate if flag is true
        transform.RotateAround(target.position, target.up, speed * Time.deltaTime);
    }
}
