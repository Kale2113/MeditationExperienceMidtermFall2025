using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [Tooltip("What this object should look at.")]
    public Transform target;

    [Tooltip("World-space up direction used to keep the view upright.")]
    public Vector3 worldUp = Vector3.up;

    [Tooltip("If > 0, rotate toward the target at this speed (deg/sec). If 0, snap instantly.")]
    public float smoothSpeed = 0f;

    void Awake()
    {
        // Fallback so it won't NRE if you forget to assign.
        if (target == null) target = transform;
    }

    void Update()
    {
        if (target == null) return;

        if (smoothSpeed <= 0f)
        {
            // Instant look-at
            transform.LookAt(target, worldUp);
        }
        else
        {
            // Smooth look-at
            Vector3 dir = (target.position - transform.position).normalized;
            Quaternion targetRot = Quaternion.LookRotation(dir, worldUp);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, targetRot, smoothSpeed * Time.deltaTime
            );
        }
    }

    // Optional helper to change targets from other scripts/UI.
    public void SetTarget(Transform newTarget) => target = newTarget;
}
