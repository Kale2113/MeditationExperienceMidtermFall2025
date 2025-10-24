using UnityEngine;

public class ChangeLookATTarget : MonoBehaviour
{
    [Tooltip("LookAtTarget components that should be retargeted (e.g., on your cameras).")]
    public LookAtTarget[] lookers;

    [Tooltip("Targets to cycle through (e.g., Sun, Earth, Moon).")]
    public Transform[] targets;

    private int index = 0;

    void Start()
    {
        Apply();
    }

    void Update()
    {
        if (targets == null || targets.Length == 0) return;

        // Press Tab to cycle targets
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            index = (index + 1) % targets.Length;
            Apply();
        }
    }

    private void Apply()
    {
        if (targets == null || targets.Length == 0 || lookers == null) return;
        foreach (var l in lookers)
        {
            if (l != null) l.target = targets[index];
        }
    }
}
