using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2MenuManager : MonoBehaviour
{
    public BreathingBubble breathingBubble;
    // Start is called before the first frame update
    public void TurnBubbleOn()
    {
        if (breathingBubble != null)
            breathingBubble.Show(true);
    }

    public void TurnBubbleOff()
    {
        if (breathingBubble != null)
            breathingBubble.Show(false);
    }
}
