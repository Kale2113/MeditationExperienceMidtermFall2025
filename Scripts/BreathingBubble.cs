using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BreathingBubble : MonoBehaviour
{
    [Header("UI Reference")]
    public Image fillImage;  

    [Header("Animation Settings")]
    public float fillSpeed = 4f;
    public float holdTime = 4f;
    public float unfillSpeed = 6f;
    public bool loop = true;

    private Coroutine breathingRoutine;

    void Start()
    {
        if (fillImage == null)
            fillImage = GetComponent<Image>();

        
        breathingRoutine = StartCoroutine(BreathingCycle());
    }

    private IEnumerator BreathingCycle()
    {
        do
        {
            
            yield return StartCoroutine(AnimateFill(0f, 1f, fillSpeed));

            
            yield return new WaitForSeconds(holdTime);

            
            yield return StartCoroutine(AnimateFill(1f, 0f, unfillSpeed));
        }
        while (loop);
    }

    private IEnumerator AnimateFill(float start, float end, float duration)
    {
        float time = 0f;
        while (time < duration)
        {
            fillImage.fillAmount = Mathf.Lerp(start, end, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        fillImage.fillAmount = end;
    }

  

    public void Show(bool visible)
    {
        fillImage.enabled = visible;
    }
}
