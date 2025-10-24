using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int speed;
    public bool rotate = false; 

    void Start()
    {
        if (target == null)
            target = this.transform; 
    }

    void Update()
    {
        if (!rotate) return; 
        transform.RotateAround(target.position, target.up, speed * Time.deltaTime);
    }
}
